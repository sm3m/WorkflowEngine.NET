﻿using System;

namespace OptimaJet.Workflow.MongoDB
{
    public class WorkflowGlobalParameter
    {
        public Guid Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}