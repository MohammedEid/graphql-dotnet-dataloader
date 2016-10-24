﻿using System;

namespace GraphQL.Annotations
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class GraphQLFuncAttribute : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Type Resolver { get; set; }
        public Type ReturnType { get; set; }
    }
}