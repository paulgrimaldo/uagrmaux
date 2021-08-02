<?php

class Materia extends AbstractModel
{

    public $id;
    public $sigla;
    public $nombre;


    public function __construct($id, $sigla, $nombre)
    {
        $this->id = $id;
        $this->sigla = $sigla;
        $this->nombre = $nombre;
    }


    public function getSaveSql($db)
    {
        $sql = $db->prepare("INSERT INTO materias (nombre, sigla) values(?,?)");
        $sql->bindParam(1, $this->nombre, PDO::PARAM_STR, 50);
        $sql->bindParam(2, $this->sigla, PDO::PARAM_STR, 50);

        return $sql;
    }

    public function setModelId()
    {
        $db = Db::getInstance();
        $this->id = $db->lastInsertId();
    }

    public static function all()
    {
        $db = DB::getInstance();
        $req = $db->query('SELECT * FROM materias');
        return $req->fetchAll();
    }
}
