﻿using System;
using System.Collections.Generic;

namespace Core_APIApps.Models;

public partial class ToDo
{
    public int Id { get; set; }

    public string Task { get; set; } = null!;
}
