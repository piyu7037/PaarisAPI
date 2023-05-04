using System;
using System.Collections.Generic;

namespace PaarisAPI.Models;

public partial class SettingFile
{
    public string FileName { get; set; } = null!;

    public string Data { get; set; } = null!;
}
