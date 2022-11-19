namespace banjo_app.Models;

public class NoteCardModel {
    public string Note {get; set;}
    public bool IsSharp {get; set;}

    public NoteCardModel(string _note, bool _isSharp = false){
        Note = _note;
        IsSharp = _isSharp;
    }
}
