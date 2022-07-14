using Acme.StudentManage.Models.SinhVien;
using AutoMapper;
using static Acme.StudentManage.Web.Pages.Commons.SinhVien.EditModalModel;

namespace Acme.StudentManage.Web;

public class StudentManageWebAutoMapperProfile : Profile
{
    public StudentManageWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<SinhVienResponse, SinhVienModel>();
    }
}
