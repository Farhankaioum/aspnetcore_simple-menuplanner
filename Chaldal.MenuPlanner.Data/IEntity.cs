﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chaldal.MenuPlanner.Data
{
    public interface IEntity<T>
    {
        T Id { get; set }
    }
}
