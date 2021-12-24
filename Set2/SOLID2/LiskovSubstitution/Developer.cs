namespace SOLID2.LiskovSubstitution
{
    internal class Developer : Employee
    {
        public override void ApproveTimeSheet()
        {
            throw new Exception("Developer cannot approve a time sheet");
        }
    }
}
