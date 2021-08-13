$(function() { 
    $('#sidebarCollapse').on('click', function() {
      $('#sidebar, #content').toggleClass('active');
    });
});


// Datatable
$(document).ready(function () {


    // Beneficiaries Dashboard New Table "Datatable"
    var BeneficiariesDashboardNewTable = $('#BeneficiariesDashboardNewTable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null
        ],
   
        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#BeneficiariesDashboardNewTablefilterbox").keyup(function () {
        BeneficiariesDashboardNewTable.search(this.value).draw();
    });


   // Beneficiaries New Table "Datatable"
    var BeneficiariesNew2Table = $('#BeneficiariesNew2Table').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null,
            null
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#BeneficiariesNew2Tablefilterbox").keyup(function () {
        BeneficiariesNew2Table.search(this.value).draw();
    });

    // Beneficiaries Closed Table "Datatable"
    var BeneficiariesClosedTable = $('#BeneficiariesClosedTable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null,
            null
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#BeneficiariesClosedTablefilterbox").keyup(function () {
        BeneficiariesClosedTable.search(this.value).draw();
    });

    // Beneficiaries Canceled Table "Datatable"
    var BeneficiariesCanceledTable = $('#BeneficiariesCanceledTable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null,
            null
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#BeneficiariesCanceledTablefilterbox").keyup(function () {
        BeneficiariesCanceledTable.search(this.value).draw();
    });
});

