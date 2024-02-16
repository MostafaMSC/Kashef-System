//function Print(divId)
//{
//    var content = document.getElementById(divId);
//    var printWindow = window.open('', '', 'width=1300,height=1100');
//    printWindow.document.open();
//    printWindow.document.write('<style>.print-table { border-collapse: collapse; } .print-table, .print-table th, .print-table td { border: 1px solid black; padding: 8px; }</style>');
//    printWindow.document.write('<table class="print-table">' + content.innerHTML + '</table>');
//    printWindow.document.write('</body>  </html>');
//    printWindow.document.close();
//    printWindow.print();

//    //var divContents = document.getElementById(divId).innerHTML;
//    //var a = window.open('', '', 'height=500, width=500');
//    //a.document.write('<html>');
//    //a.document.write('<body > <br>');
//    //a.document.write(divContents);
//    //a.document.write('</body></html>');
//    //a.document.close();
//    //a.print();

//}


function print(Area2) {
    var content = document.getElementById(Area2).innerHTML;
    var printWindow = window.open('', '', 'width=1300,height=1100');
    printWindow.document.open();
    printWindow.document.write('<style>');
    printWindow.document.write('.print-table { border-collapse: collapse; width: 100%;font-size:20px }');
    printWindow.document.write('.print-table th, .print-table td { border: 1px solid black; padding: 8px; text-align: right; font-size:20px }');
    printWindow.document.write('</style>');
    printWindow.document.write('<style> body { direction: rtl; font-size:20px}</style>');
    printWindow.document.write('<div class="print-table">' + content + '</div>');
    printWindow.document.write('</body>  </html>');
    printWindow.document.close();
    printWindow.print();
}
