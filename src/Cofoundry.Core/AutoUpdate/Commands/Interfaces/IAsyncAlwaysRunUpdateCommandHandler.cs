﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofoundry.Core.AutoUpdate
{
    /// <summary>
    /// Handler for executing IVersionedUpdateCommand asynchronously
    /// </summary>
    /// <typeparam name="TCommand">Type of command to execute</typeparam>
    public interface IAsyncAlwaysRunUpdateCommandHandler<in TCommand> : IAlwaysRunUpdateCommandHandler<TCommand>  
        where TCommand : IAlwaysRunUpdateCommand
    {
        /// <summary>
        /// Executes the specified command asynchronously.
        /// </summary>
        /// <param name="command">Command to execute</param>
        Task ExecuteAsync(TCommand command);
    }
}
