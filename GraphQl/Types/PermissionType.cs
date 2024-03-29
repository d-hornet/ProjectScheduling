﻿using GraphQL.Types;
using Scheduling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduling.GraphQl.Types
{
    public class PermissionType: ObjectGraphType<Permission>
    {
        public PermissionType()
        {
            Name = "Permission";

            Field(permision => permision.Id).Description("Permision id.");
            Field(permision => permision.Name).Description("Permision name.");
        }

    }
}
