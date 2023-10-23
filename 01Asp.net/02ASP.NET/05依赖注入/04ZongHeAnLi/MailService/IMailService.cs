namespace MailService {
    public interface IMailService {
        public void Send(string title, string to, string body);
    }
}