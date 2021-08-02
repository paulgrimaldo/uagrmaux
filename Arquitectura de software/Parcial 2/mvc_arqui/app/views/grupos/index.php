<?php
require_once('../app/views/template/header.php');
?>
    <div class="row">
        <div class="col-sm-12">
            <div class="card-box">
                <h4 class="m-t-0 header-title"><b>Registrar nuevo grupo</b></h4>
                <p class="text-muted m-b-30 font-13"></p>
                <p style="color: #2f24ff"> <?php echo $mensaje; ?></p>
                <div class="row">
                    <form method="post" action="?controller=Grupos&action=guardar">
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Nombre<span class="text-danger"></span></label>
                                <input type="text" parsley-trigger="Nombre del alumno" required=""
                                       placeholder="Ingresar el nombre" class="form-control" id="nombre"
                                       name="nombre">
                            </div>
                            <div class="form-group">
                                <label>Curso materia</label>
                                <select class="custom-select mt-3" id="cursoMateriaId" name="cursoMateriaId">
                                    <option selected="">Seleccione un curso materia</option>
                                    <?php foreach ($cursosMaterias as $cursoMateria) { ?>
                                        <option value="<?php echo $cursoMateria[0]; ?>">
                                            <?php echo $cursoMateria[1].' - '.$cursoMateria[2].', '.$cursoMateria[3]; ?>
                                        </option>
                                    <?php } ?>
                                </select>
                            </div>
                        </div>
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
                        <th>Nombre</th>
                        <th>Curso Materia</th>
                        <th>Opciones</th>
                    </tr>
                    </thead>
                    <tbody>
                    <?php
                    foreach ($grupos as $grupo) { ?>
                        <tr class="gradeX">
                            <td><?php echo $grupo[0]; ?></td>
                            <td><?php echo $grupo[1]; ?></td>
                            <td><?php echo $grupo[2]; ?></td>
                            <td class="actions">
                                <a href="?controller=Grupos&action=editar&id=<?php echo $grupo[0]; ?>"
                                   class="on-default edit-row" data-toggle="tooltip" data-placement="top"><i
                                            class="fa fa-pencil"></i>
                                </a>
                                <a href="?controller=Grupos&action=eliminar&id=<?php echo $grupo[0]; ?>"
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