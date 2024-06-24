using TechJobs6Persistent.Models;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TechJobs6Persistent.ViewModels;

public class AddJobViewModel
{
    public string? JobName { get; set; }

    public int EmployerId {get; set; }

    public List<SelectListItem> Employers { get; set; }
}
