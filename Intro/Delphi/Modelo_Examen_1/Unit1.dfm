object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 462
  ClientWidth = 485
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object TxtDato: TEdit
    Left = 136
    Top = 72
    Width = 121
    Height = 21
    TabOrder = 0
    Text = 'TxtDato'
  end
  object TxtResultado: TEdit
    Left = 136
    Top = 136
    Width = 121
    Height = 21
    TabOrder = 1
    Text = 'TxtResultado'
  end
  object MainMenu1: TMainMenu
    object Ejercicios1: TMenuItem
      Caption = 'Ejercicios'
      object VerificarOrdenado1: TMenuItem
        Caption = 'Verificar Ordenado'
        OnClick = VerificarOrdenado1Click
      end
      object EliminarVocales1: TMenuItem
        Caption = 'Eliminar Vocales'
        OnClick = EliminarVocales1Click
      end
      object Sumatoria1: TMenuItem
        Caption = 'Sumatoria'
        OnClick = Sumatoria1Click
      end
      object Invertirultimapalabra1: TMenuItem
        Caption = 'Invertir ultima palabra'
        OnClick = Invertirultimapalabra1Click
      end
    end
  end
end
