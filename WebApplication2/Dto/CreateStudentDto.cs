namespace WebApplication2.Dto
{
    public class CreateStudentDto
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value?.Trim();
        }
        public string StudentCode { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
