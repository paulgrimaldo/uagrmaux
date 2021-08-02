<?php

class AlumnoGrupo extends AbstractModel
{

    public $id;
    public $alumnoId;
    public $grupoId;


    public function __construct($id, $alumnoId, $grupoId)
    {
        $this->id = $id;
        $this->alumnoId = $alumnoId;
        $this->grupoId = $grupoId;
    }

    public function getSaveSql($db)
    {
        $sql = $db->prepare("INSERT INTO alumnos_grupos (alumno_id, grupo_id) values(?, ?)");
        $sql->bindParam(1, $this->alumnoId, PDO::PARAM_INT);
        $sql->bindParam(2, $this->grupoId, PDO::PARAM_INT);

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
        $req = $db->query('SELECT ag.id, a.nombre, g.nombre FROM alumnos_grupos ag
join alumnos a on a.id=ag.alumno_id join grupos g on g.id = ag.grupo_id');
        return $req->fetchAll();
    }

    public static function exists($alumnoId, $grupoId)
    {
        $db = Db::getInstance();
        $sql = 'SELECT * FROM alumnos_grupos WHERE alumno_id="' . $alumnoId . '" and grupo_id="' . $grupoId . '"';
        $req = $db->query($sql);
        return $req->fetchAll();
    }
}