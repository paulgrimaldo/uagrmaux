unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    NTerminos: TEdit;
    TxtResult: TEdit;
    Label1: TLabel;
    Button1: TButton;
    Button2: TButton;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
var
   s, n : Integer;

   text: String;
begin
    s:=0;
    text:= IntToStr(s);

    n:=    StrToInt(NTerminos.Text);

    while (n>0) do
    begin
      s:=s+1;
      text:=text + ' ' + IntToStr(s)   ;
      n:=n-1;
    end;
    TxtResult.Text := text;
end;

procedure TForm1.Button2Click(Sender: TObject);
var
  s1, s2, n : Integer;
  sw: Boolean;
  text: String;
begin
   sw:= True;
   s1:=0;
   s2:=-3;
   text:='';
   n:=    StrToInt(NTerminos.Text);
   while (n>0) do
    begin
      if (sw = True) then
      begin
        s1:=s1+1;
        text:=text +    ' ' + IntToStr(s1)   ;
        sw:=False;
      end
      else
      begin
         s2:=s2+3;
         text:=text +    ' ' + IntToStr(s2)   ;
         sw:=True;
      end;
      n:=n-1;
    end;
    TxtResult.Text := text;
end;

end.
