<?php


class Curso extends AbstractModel
{
    public $id;
    public $nombre;
    public $nivel;

    public function __construct($id, $nombre, $nivel)
    {
        $this->id = $id;
        $this->nombre = $nombre;
        $this->nivel = $nivel;
    }

    public function getSaveSql($db)
    {
        $sql = $db->prepare("INSERT INTO cursos (nombre,nivel) values(?,?)");
        $sql->bindParam(1, $this->nombre, PDO::PARAM_STR, 50);
        $sql->bindParam(2, $this->nivel, PDO::PARAM_INT);

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
        $req = $db->query('SELECT * FROM cursos');
        return $req->fetchAll();
    }
}
