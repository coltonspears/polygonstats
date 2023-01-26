using System;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Text;
using Serilog;
using PolygonStatsPlugins.Configuration;

namespace PolygonStatsPlugins.HttpServer
{
    public class PluginHTTPServer: IDisposable
    {

        private Thread PluginServerThread { get; set; }
        public HttpListener Listener { get; private set; }
        public int Port { get; private set; }


        public PluginHTTPServer(int port)
        {
            Initialize(port);
        }

        public PluginHTTPServer()
        {
            TcpListener l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();
            int port = ((IPEndPoint)l.LocalEndpoint).Port;
            l.Stop();
            this.Initialize(port);
        }

        public void Stop()
        {
            Listener.Stop();
        }

        private void Listen()
        {
            Listener = new HttpListener();
            Listener.Prefixes.Clear();
            Listener.Prefixes.Add($"http://localhost:{Port}/");
            Listener.Start();
            while (Listener.IsListening)
            {
                try
                {
                    HttpListenerContext context = Listener.GetContext();
                    Process(context);
                }
                catch (Exception ) { }
            }
        }

        private static void Process(HttpListenerContext context)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(PluginHttpHelper.GetData());

                context.Response.ContentType = "text/html";
                context.Response.ContentEncoding = Encoding.UTF8;
                context.Response.ContentLength64 = data.LongLength;

                context.Response.OutputStream.Write(data, 0, data.Length);

                context.Response.StatusCode = (int)HttpStatusCode.OK;
                context.Response.OutputStream.Flush();
            }
            catch (Exception)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

            context.Response.OutputStream.Close();
        }

        private void Initialize(int port)
        {
            Port = port;
            PluginServerThread = new Thread(this.Listen);
            PluginServerThread.Start();
            Log.Information($"Plugin HTTP Server started on port {port}");
        }

        public void Dispose()
        {
            Log.Information("Plugin HTTP Server stopping...");
            Stop();
        }
    }
}