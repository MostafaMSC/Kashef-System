
function print(Area2) {
    var content = document.getElementById(Area2).innerHTML;
    var printWindow = window.open('','', 'width=1300,height=1100');
    printWindow.document.open();
    printWindow.document.write('<style>');
    printWindow.document.write('.print-table { border-collapse: collapse; width: 100%;font-size:20px }');
    printWindow.document.write('.print-table th, .print-table td { border: 1px solid black; text-align: center; font-size:20px; width=300px }');
    printWindow.document.write('</style>');
    printWindow.document.write('<style> body { direction: rtl; font-size:20px}</style>');
    printWindow.document.write('<div class="print-table">' + content + '</div>');
    printWindow.document.write('</body></html>');
    printWindow.document.close();
    printWindow.print();
}
