unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, uPersona;

type
  TForm1 = class(TForm)
    TxtNombre: TEdit;
    TxtCi: TEdit;
    Edit3: TEdit;
    BtnCrear: TButton;
    procedure BtnCrearClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  p:Persona;

implementation

{$R *.dfm}

procedure TForm1.BtnCrearClick(Sender: TObject);
begin
   p:=Persona.crear;

   p.SetNombre(TxtNombre.Text);
   p.SetCi(TxtCi.Text);
   //p.VotarPorCsi;

   Edit3.Text:=p.ToStr;
end;

end.
