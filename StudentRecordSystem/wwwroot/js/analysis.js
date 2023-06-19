// Reference: http://www.i-visionblog.com/2014/11/jquery-animated-number-counter-from-zero-to-value-jquery-animation.html 
$('.count').each(function () {
    $(this).prop('Counter', 0).animate({
        Counter: $(this).text()
    }, {
        duration: 4000,
        easing: 'swing',
        step: function (now) {
            $(this).text(Math.ceil(now));
        }
    });
});