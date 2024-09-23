namespace Chatx.Models
{
    public class HangHoaNV
    {
        public string TenHangHoa { get; set; }
        public double DonGia {  get; set; } 
    }
    public class HangHoa : HangHoaNV
    {
        public Guid MaHangHoa { get; set; }
    }
}
