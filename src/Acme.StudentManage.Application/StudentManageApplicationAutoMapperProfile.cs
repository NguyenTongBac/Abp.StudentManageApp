using Acme.StudentManage.Entities.Common;
using Acme.StudentManage.Models.Lop;
using Acme.StudentManage.Models.SinhVien;
using AutoMapper;

namespace Acme.StudentManage;

public class StudentManageApplicationAutoMapperProfile : Profile
{
    public StudentManageApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<SinhVien, SinhVienResponse>();
        CreateMap<SinhVienRequest, SinhVien>();
        CreateMap<SinhVienResponse, SinhVienRequest>();

        CreateMap<Lop, LopResponse>();
        CreateMap<LopRequest, Lop>();
        CreateMap<LopResponse, LopRequest>();
    }
}
