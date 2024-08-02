namespace ProjetDLL.DesignPattern.Comportement.ChainOfResponsability
{
    public class ComplaintRequest
    {
        public enum ComplaintState
        {OPENED, CLOSED};

        public int StudentNumber { get; set; }

        //Selon le type, la plainte sera traitée par un membre: 1- Prof - 2-Padago - 3- Directeur
        public int ComplaintType { get; set; }
        public string Message { get; set; }
        public ComplaintState State { get; set; }

        public ComplaintRequest(int studentNumber, int complaintType, string message, ComplaintState state)
        {
            StudentNumber = studentNumber;
            ComplaintType = complaintType;
            Message = message;
            State = state;
        }
    }
}