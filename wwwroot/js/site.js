// Write your Javascript code.
$( "#sam" ).click(function(){
   $("#adam").show(100);
   $(this).hide(100);
});

$( "#adam" ).click(function(){
    $("#sam").show(100);
    $(this).hide(100);
});

$( "#sambutton" ).click(function(){
   $("#sam").show(100);
   $("#adamorsam").hide(100);
});

$( "#adambutton" ).click(function(){
    $("#adam").show(100);
    $("#adamorsam").hide(100);
});





// $( "#1" ).click(function(){
//     $("#1").text("Changed again");
// });

// Reload page will always start at top of page
$(document).ready(function(){
    $('html, body').scrollTop(0);

    $(window).on('load', function() {
    $("#sam").hide(); 
    $("#adam").hide();  
    $("#adamorsam").show();
    setTimeout(function(){
        $('html, body').scrollTop(0);
    }, 0);
 });


});