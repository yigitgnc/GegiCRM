/**
 * Perfect Scrollbar
 */
'use strict';

document.addEventListener('DOMContentLoaded', function () {
    (function () {
        const verticalExample = document.getElementById('vertical-example'),
            horizontalExample = document.getElementById('horizontal-example'),
            horizVertExample = document.getElementById('both-scrollbars-example');

        // Vertical Example
        // --------------------------------------------------------------------
        if (verticalExample) {
            new PerfectScrollbar(verticalExample, {
                wheelPropagation: false
            });
        }

        // Horizontal Example
        // --------------------------------------------------------------------
        if (horizontalExample) {
            new PerfectScrollbar(horizontalExample, {
                wheelPropagation: false,
                suppressScrollY: true
            });
        }

        // Both vertical and Horizontal Example
        // --------------------------------------------------------------------
        if (horizVertExample) {
            new PerfectScrollbar(horizVertExample, {
                wheelPropagation: false
            });
        }
        var pss = document.getElementsByClassName('ps');
        console.log(pss);
        for (var i = 0; i < pss.length; i++) {
            var item = pss[i];
            new PerfectScrollbar(item, {
                wheelPropagation: false
            });
        }
    })();
});
