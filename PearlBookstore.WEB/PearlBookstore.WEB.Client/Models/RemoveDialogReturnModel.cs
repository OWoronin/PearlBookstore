namespace PearlBookstore.WEB.Client.Models
{
    public class RemoveDialogReturnModel(DialogModel model)
    {
        public int ID { get; set; } = model.ID;

        public string Title { get; set; } = model.Title;

        public bool Remove { get; set; }

        public int TypeID { get; set; } = model.TypeID;
    }
}
