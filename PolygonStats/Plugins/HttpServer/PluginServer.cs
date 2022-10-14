using System;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Text;

namespace PolygonStats.Plugins
{
    public class PluginServer
    {

        private Thread PluginServerThread { get; set; }
        public HttpListener Listener { get; private set; }
        public int Port { get; private set; }


        public PluginServer(int port)
        {
            Initialize(port);
        }

        public PluginServer()
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
            Listener.Prefixes.Add($"http://*:{Port}/");
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
                byte[] data = Encoding.UTF8.GetBytes(PluginHttpHelper.getData());

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
        }
    }
}