﻿namespace ChainOfResponsibility.Operations
{
    public class SubstractOperation : IChain
    {
        private readonly IChain _next;


        public SubstractOperation(IChain next = null)
        {
            _next = next;
        }

        public double? Calculate(Command command)
        {
            if (command.Operation == "-")
            {
                return command.Number1 - command.Number2;
            }
            else
            {
               return _next?.Calculate(command);
            }
        }
    }
}
