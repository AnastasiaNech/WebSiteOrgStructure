﻿namespace WebSiteOrgStructure.Dtos;

public class DepartmentDto
{

    public Guid Id { get; set; }
    public string? DepartmentName { get; set; }
    public string? ParentDepartmentName { get; set; }
}