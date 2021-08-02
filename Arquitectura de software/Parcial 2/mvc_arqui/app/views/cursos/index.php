<?php
require_once('../app/views/template/header.php');
?>
    <div class="row">
        <div class="col-sm-12">
            <div class="card-box">
                <h4 class="m-t-0 header-title"><b>Registrar nuevo curso</b></h4>
                <p class="text-muted m-b-30 font-13"></p>
                <p style="color: #2f24ff"> <?php echo $mensaje; ?></p>
                <div class="row">
                    <form method="post" action="?controller=Cursos&action=guardar">
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Nombre<span class="text-danger"></span></label>
                                <input type="text" parsley-trigger="Nombre del curso" required=""
                                       placeholder="Ingresar el nombre" class="form-control" id="nombre"
                                       name="nombre">
                            </div>
                            <div class="form-group">
                                <label>Nivel<span class="text-danger"></span></label>
                                <input type="number" parsley-trigger="Nivel" required=""
                                       placeholder="Ingresar el nivel" class="form-control" id="nivel"
                                       name="nivel">
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
                        <th>Nivel</th>
                        <th>Opciones</th>
                    </tr>
                    </thead>
                    <tbody>
                    <?php
                    foreach ($cursos as $curso) { ?>
                        <tr class="gradeX">
                            <td><?php echo $curso[0]; ?></td>
                            <td><?php echo $curso[1]; ?></td>
                            <td><?php echo $curso[2]; ?></td>
                            <td class="actions">
                                <a href="?controller=Cursos&action=editar&id=<?php echo $curso[0]; ?>"
                                   class="on-default edit-row" data-toggle="tooltip" data-placement="top"><i
                                            class="fa fa-pencil"></i>
                                </a>
                                <a href="?controller=Cursos&action=eliminar&id=<?php echo $curso[0]; ?>"
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