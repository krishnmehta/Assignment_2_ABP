using AutoMapper;
using StudentAssignment.Students;

namespace StudentAssignment;

public class StudentAssignmentApplicationAutoMapperProfile : Profile
{
    public StudentAssignmentApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Student, StudentDto>();
        CreateMap<CreateUpdateStudentDto, Student>();
    }
}
