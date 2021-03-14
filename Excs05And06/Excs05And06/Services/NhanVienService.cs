using System.Collections.ObjectModel;
using System.Linq;

namespace Excs05And06.Services
{
    class NhanVienService
    {
        public  ObservableCollection<Models.NhanVien> DSNhanVien = new ObservableCollection<Models.NhanVien>
        {
            new Models.NhanVien { ID = 1, NgaySinh = "01/01/1997", Name = "Jenny Dalby",
                IMG="https://images.unsplash.com/photo-1595399874399-10f2444c4eb2?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=475&q=80",
                Desc = "Nửa đời sầu nửa đời âu"},
            new Models.NhanVien { ID = 2, NgaySinh = "01/01/1997", Name = "Jonv",
                Desc = "Gập ghềnh mưa gió Nửa đời người",
                IMG="https://images.unsplash.com/photo-1569466896818-335b1bedfcce?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=80"},
            new Models.NhanVien { ID = 3, NgaySinh = "01/01/1997", Name = "RachelMartin",
                Desc = "Chợt nhận ra tuyết rơi bên khung cửa sổ",
                IMG="https://images.unsplash.com/photo-1612041720569-7e67f4061729?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=480&q=80"},
            new Models.NhanVien { ID = 4, NgaySinh = "01/01/1997", Name = "Nivan Jay",
                Desc = "lệ ta rơi lòng ta đau",
                IMG="https://images.unsplash.com/photo-1610216705422-caa3fcb6d158?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=80"},
            new Models.NhanVien { ID = 5, NgaySinh = "01/01/1997", Name = "SanazZ",
                Desc = "thừa cô đơn quá dư u sầu",
                IMG="https://images.unsplash.com/photo-1612417783135-89e4571fe8e0?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=493&q=80"},
            new Models.NhanVien { ID = 6, NgaySinh = "01/01/1997", Name = "NextLab",
                Desc = "Tìm men say chỉ mong sẽ yên lòng hơn",
                IMG="https://images.unsplash.com/photo-1607283455867-3c1dc4166f26?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=548&q=80"},
            new Models.NhanVien { ID = 7, NgaySinh = "01/01/1997", Name = "AlexB",
                Desc = "mình tôi lê bước lạc vào giấc mơ hão huyền",
                IMG="https://images.unsplash.com/photo-1593692667732-d53fdaec0b60?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=80"},
            new Models.NhanVien { ID = 8, NgaySinh = "01/01/1997", Name = "Tara Chang",
                Desc = "mà đâu biết em phũ phàng",
                IMG="https://images.unsplash.com/photo-1551712702-4b7335dd8706?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=80" },
            new Models.NhanVien { ID = 9, NgaySinh = "01/01/1997", Name = "Tom K",
                Desc = "Thiên Sơn đất trời ngàn bình rượu đựng nào vơi tổn thương bấy lâu",
                IMG="https://images.unsplash.com/photo-1597223557154-721c1cecc4b0?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=80" },
        };

        public Models.NhanVien GetNhanVien(int Id)
        {
            return DSNhanVien.SingleOrDefault(u => u.ID == Id);
        }
    }
}
