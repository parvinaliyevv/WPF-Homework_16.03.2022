﻿using System;
using System.Windows.Input;

namespace EyeMedia.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;


        private Predicate<object?> _canExecute;
        private Action<object?> _execute;


        public RelayCommand(Action<object?> execute, Predicate<object?> canExecute = null)
        {
            if (execute is null) throw new ArgumentNullException(nameof(execute));

            _execute = execute;
            _canExecute = canExecute;
        }


        public bool CanExecute(object? parameter)
            => _canExecute is null || _canExecute.Invoke(parameter);

        public void Execute(object? parameter)
            => _execute.Invoke(parameter);
    }
}
