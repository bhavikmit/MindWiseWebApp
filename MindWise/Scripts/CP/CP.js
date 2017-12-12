$(function () {
    tblDUMPSLDG();
    $("#btnSearchCP").on("click", function () {
        tblDUMPSLDG();
    });
});

function tblDUMPSLDG() {
    $("#tblDUMPSLDG").dataTable({
        "bServerSide": true,
        "bProcessing": true,
        "bFilter": false,
        "bSort": false,
        "destroy": true,
        "bLengthChange": false,
        //"sDom": '<"top"<"actions">lfpi<"clear">><"clear">rt<"bottom">',
        "bInfo": true,
        responsive: true,
        "sServerMethod": "POST",
        sAjaxSource: "/CP/GetDUMPSLDG",
        "fnServerData": function (sSource, aoData, fnCallback) {
            aoData.push({
                "name": "SerchBy",
                "value": $("#txtSearchCP").val()
            });
            $.getJSON(sSource, aoData, function (json) {
                fnCallback(json);
            });
        },

        "oLanguage": {
            "oPaginate": {
                "sFirst": "<<", // This is the link to the first page
                "sPrevious": "<", // This is the link to the previous page
                "sNext": ">", // This is the link to the next page
                "sLast": ">>" // This is the link to the last page
            }
            //"sProcessing": "<img src='/Assets/images/loading-blue.gif' style='height:100px;width:100px'/>"
        },
        "order": [
            [0, "desc"]
        ],
        "iDisplayLength": $("#hdnRecordPerPage").val(),
        "sPaginationType": "full_numbers",
        "aoColumns": [{
            "aTargets": [0],
            "sName": "Tracks",
            "mRender": function (data, type, row) {
                return row[0];
            }
        },
        {
            "aTargets": [1],
            "mData": "Price",
            "mRender": function (data, type, row) {
                return row[1];
            }
        },
        {
            "aTargets": [2],
            "mData": "Refundable",
            "mRender": function (data, type, row) {
                return row[2];
            }
        },
        {
            "aTargets": [3],
            "mData": "State",
            "mRender": function (data, type, row) {
                return row[3];
            }
        },
        {
            "aTargets": [4],
            "mData": "City",
            "mRender": function (data, type, row) {
                return row[4];
            }
        }, {
            "aTargets": [5],
            "mData": "Zip",
            "mRender": function (data, type, row) {
                return row[5];
            }
        },
        {
            "mData": "Action",
            "orderable": false,
            "mRender": function (data, type, row) {
                return "<a href='#'><button type='button' class='btn btn-xs btn-success'>Buy</button></a>";
            }
        }
        ]
    });
}