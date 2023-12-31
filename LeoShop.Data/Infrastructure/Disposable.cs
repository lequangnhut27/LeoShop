﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeoShop.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing && !isDisposed)
            {
                DisposeCore();
            }
            isDisposed = true;
        }

        protected virtual void DisposeCore() { }

        ~Disposable()
        {
            Dispose(false);
        }
    }
}
