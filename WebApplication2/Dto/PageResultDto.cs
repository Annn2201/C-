using WebApplication2.Entities;

namespace WebApplication2.Dto
{
    public class PageResultDto<T>
    {
        public T Items { get; set; }
        public int TotalItem { get; set; }
    }
}
