﻿using System;

namespace Lazy
{
    /// <summary>
    /// A class that implements the ILazy interface in single-threaded mode.
    /// </summary>
    /// <typeparam name="T">Parameter type.</typeparam>
    public class Lazy<T> : ILazy<T>
    {
        public Lazy(Func<T> supplier)
            => _supplier = supplier ?? throw new ArgumentNullException(nameof(supplier), "Func can't be null.");

        private Func<T> _supplier;
        private T _result;
        private bool _isResultCalculated;
        
        public T Get()
        {
            if (!_isResultCalculated)
            {
                _result = _supplier();
                _supplier = null;
                _isResultCalculated = true;
            }

            return _result;
        }
    }
}
