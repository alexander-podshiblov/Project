namespace Task_Manager_Classes
{
    public class Member
    {
        public Member() { }
        public Member(string fn, string p, string ln, int dep_id, int l)
        {
            fstName = fn;
            patronymic = p;
            lstName = ln;
            depID = dep_id;
            level = l;
        }
        public string fstName { get; set; }
        public string patronymic { get; set; }
        public string lstName { get; set; }
        public int depID { get; set; }
        public int level { get; set; }
    }
}
