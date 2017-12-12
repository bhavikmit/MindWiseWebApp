$(function () {
    tblCVVLDG();
    $("#btnSearchCNP").on("click", function () {
        tblCVVLDG();
    });
});

function tblCVVLDG() {
    var oTable = $("#tblCVVLDG").dataTable({
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
        sAjaxSource: "/CNP/GetCVVLDG",
        "fnServerData": function (sSource, aoData, fnCallback) {
            aoData.push({
                "name": "SerchBy",
                "value": $("#txtSearchCNP").val()
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
            "sName": "FirstName",
            "mRender": function (data, type, row) {
                return row[0];
            }
        },
        {
            "aTargets": [1],
            "mData": "LastName",
            "mRender": function (data, type, row) {
                return row[1];
            }
        },
        {
            "aTargets": [2],
            "mData": "Address",
            "mRender": function (data, type, row) {
                return row[2];
            }
        },
        {
            "aTargets": [3],
            "mData": "Price",
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
            "mData": "State",
            "mRender": function (data, type, row) {
                return row[5];
            }
        },
        {
            "aTargets": [6],
            "mData": "Zip",
            "mRender": function (data, type, row) {
                return row[6];
            }
        },
        {
            "aTargets": [7],
            "mData": "DOB",
            "mRender": function (data, type, row) {
                return row[7];
            }
        },
        {
            "aTargets": [8],
            "mData": "Phone",
            "mRender": function (data, type, row) {
                return row[8];
            }
        },
        {
            "aTargets": [9],
            "mData": "Gender",
            "mRender": function (data, type, row) {
                return row[9];
            }
        },
        {
            "aTargets": [10],
            "mData": "SSN",
            "mRender": function (data, type, row) {
                return row[10];
            }
        },
        {
            "aTargets": [11],
            "mData": "DateADDED",
            "mRender": function (data, type, row) {
                return row[11];
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
