$(document).ready(function()
{
    $(".ul-repeater-default").repeater({
      show:function(){
        $(this).slideDown()
      },
      hide:function(e){
        confirm("Are you sure you want to delete ??????")&&$(this).slideUp(e)}
    })
});

