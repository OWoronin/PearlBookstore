﻿namespace PearlBookstore.WEB.Client.Models
{
    public class AddDialogReturnModel(DialogModel model)
    {
        public int ID { get; set; } = model.ID;

        public string Title { get; set; } = model.Title;

        public bool ChangeTab { get; set; }
    }
}