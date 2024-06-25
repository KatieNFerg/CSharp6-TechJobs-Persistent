using TechJobs6Persistent.Models;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TechJobs6Persistent.ViewModels;

public class AddJobViewModel
{
    [Required(ErrorMessage ="Job name is required!")]
    public string? JobName { get; set; }

    public int EmployerId {get; set; }

    public List<SelectListItem>? Employers { get; set; }

    public AddJobViewModel(List<Employer>employers)
    {
        Employers = new List<SelectListItem>();

        foreach(var employer in employers)
        {
            Employers.Add(
                new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            
        }
    }
    public AddJobViewModel()
    {

    }
}
