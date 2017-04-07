using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GovDocSearch.cc.topware.form
{
    class UploadDelegate
    {
        private object obj;
        public delegate void initUpload(Object obj);
        public event initUpload initUploadHandler;

        public UploadDelegate(Object obj)
        {
            this.obj = obj;
        }

        public void threadStart()
        {
            ThreadStart ts = new ThreadStart(start);
            Thread thread = new Thread(ts);
            //thread.IsBackground = true;
            thread.Start();
            Thread.Sleep(0);
        }

        public void start()
        {
            initUploadHandler(obj);
        }
    }
}
