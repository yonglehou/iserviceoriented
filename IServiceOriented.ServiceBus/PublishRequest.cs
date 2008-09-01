﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IServiceOriented.ServiceBus
{
    /// <summary>
    /// Represents a request to publish a message
    /// </summary>
    public class PublishRequest
    {
        protected PublishRequest()
        {
        }

        public PublishRequest(Type contract, string action, object message) : 
            this(contract, action, message, new ReadOnlyDictionary<string,object>())
        {
        }
        public PublishRequest(Type contract, string action, object message, ReadOnlyDictionary<string, object> context)
        {
            ContractType = contract;
            Action = action;
            Message = message;
            Context = context;
        }

        /// <summary>
        /// Gets the type of the contract associated with the message
        /// </summary>
        public Type ContractType
        {
            get;
            private set;
        }
        
        /// <summary>
        /// Gets the action associated with the message
        /// </summary>
        public string Action
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the message to publish
        /// </summary>
        public object Message
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the contex associated with the message
        /// </summary>
        public ReadOnlyDictionary<string, object> Context
        {
            get;
            private set;
        }
    }
}