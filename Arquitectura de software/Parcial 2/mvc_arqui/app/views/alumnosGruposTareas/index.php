<?php
require_once('../app/views/template/header.php');
?>
    <div class="row">
        <div class="col-sm-12">
            <div class="card-box">
                <h4 class="m-t-0 header-title"><b>Realizar presentación</b></h4>
                <p class="text-muted m-b-30 font-13"></p>
                <p style="color: #2f24ff"> <?php echo $mensaje; ?></p>
                <div class="row">
                    <form method="post" action="?controller=AlumnosGruposTareas&action=guardar">
                        <?php for ($i = 0; $i < 3; $i++) { ?>
                            <div class="col-lg-12">
                                <div class="row">
                                    <div class="col-lg-6">
                                        <div class="form-group">
                                            <label>Alumno Grupo</label>
                                            <select class="custom-select mt-3" id="alumnosGruposId[]"
                                                    name="alumnosGruposId[]">
                                                <option selected="" disabled>Seleccione un alumno</option>
                                                <?php foreach ($alumnosGrupos as $ag) { ?>
                                                    <option value="<?php echo $ag[0]; ?>"><?php echo $ag[1] . ', ' . $ag[2]; ?></option>
                                                <?php } ?>
                                            </select>
                                        </div>
                                    </div>
                                    <div class="col-lg-6">
                                        <label>Tarea</label>
                                        <select class="custom-select mt-3" id="tareasId[]" name="tareasId[]">
                                            <option selected="" disabled>Seleccione una tarea</option>
                                            <?php foreach ($tareas as $tarea) { ?>
                                                <option value="<?php echo $tarea[0]; ?>"><?php echo $tarea[1]; ?></option>
                                            <?php } ?>
                                        </select>
                                    </div>
                                    <div class="col-lg-6">
                                        <div class="form-group">
                                            <label>Calificacion<span class="text-danger"></span></label>
                                            <input type="text" parsley-trigger="Calificacion"
                                                   placeholder="Calificacion" class="form-control" id="calificaciones[]"
                                                   name="calificaciones[]">
                                        </div>
                                    </div>

                                    <div class="col-lg-6">
                                        <div class="form-group">
                                            <label>Partes tarea<span class="text-danger"></span></label>
                                            <textarea name="partesTareas[]" class="form-control"
                                                      id="partesTareas[]"></textarea>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <br>
                        <?php } ?>
                        <!-- end col -->
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="m-b-30">
                                    <button id="addToTable" type="submit"
                                            class="btn btn-success waves-effect waves-light">
                                        Guardar<i class="mdi mdi-plus-circle-outline"></i></button>
                                </div>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
    <!-- end row-->
    <div class="row">
        <div class="col-sm-12">
            <div class="card-box">
                <table class="table table-striped add-edit-table" id="datatable-editable">
                    <thead>
                    <tr>
                        <th>Codigo</th>
                        <th>Tarea</th>
                        <th>Alumno</th>
                        <th>Grupo</th>
                        <th>Calificacion</th>
                        <th>Parte subida</th>
                        <th>Opciones</th>
                    </tr>
                    </thead>
                    <tbody>
                    <?php
                    foreach ($alumnosGruposTareas as $agt) { ?>
                        <tr class="gradeX">
                            <td><?php echo $agt[0]; ?></td>
                            <td><?php echo $agt[1]; ?></td>
                            <td><?php echo $agt[2]; ?></td>
                            <td><?php echo $agt[3]; ?></td>
                            <td><?php echo $agt[4]; ?></td>
                            <td><?php echo $agt[5]; ?></td>
                            <td class="actions">
                                <a href="?controller=AlumnosGruposTareas&action=editar&id=<?php echo $agt[0]; ?>"
                                   class="on-default edit-row" data-toggle="tooltip" data-placement="top"><i
                                            class="fa fa-pencil"></i>
                                </a>
                                <a href="?controller=AlumnosGruposTareas&action=eliminar&id=<?php echo $agt[0]; ?>"
                                   class="on-default remove-row" data-toggle="tooltip" data-placement="top"><i
                                            class="fa fa-trash-o"></i>
                                </a>
                            </td>
                        </tr>
                    <?php } ?>
                    </tbody>
                </table>
            </div>
        </div>
        <!-- end: page -->
    </div> <!-- end Panel -->

<?php
require_once('../app/views/template/footer.php');
?>