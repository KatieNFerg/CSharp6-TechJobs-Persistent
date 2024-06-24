using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent;

public class AddEmployerViewModel
{
    [Required(ErrorMessage = "Please enter a name!")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Please enter a location!")]
    public string? Location { get; set; }
}
