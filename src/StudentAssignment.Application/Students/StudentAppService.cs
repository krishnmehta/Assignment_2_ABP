using Microsoft.AspNetCore.Authorization;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace StudentAssignment.Students;
[Authorize]
public class StudentAppService :
    CrudAppService<
        Student, //The Book entity
        StudentDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateStudentDto>, //Used to create/update a book
    IStudentAppService //implement the IBookAppService
{
    public StudentAppService(IRepository<Student, Guid> repository)
        : base(repository)
    {

    }
}
