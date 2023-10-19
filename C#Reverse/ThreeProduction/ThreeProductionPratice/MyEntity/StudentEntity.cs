namespace MyEntity {
    public class StudentEntity {
        public string StuID { get; set; }
        public string StuName { get; set; }
        public int StuAge { get; set; }
        public string StuSex { get; set; }
        public string StuHobby { get; set; }
        public int ProfessionID { get; set; }
        public string ProfessionName { get; set; }

        public StudentEntity() {
            StuID = "";
            StuName = "";
            StuAge = 0;
            StuSex = "";
            StuHobby = "";
            ProfessionID = 0;
            ProfessionName = "";
        }
    }
}