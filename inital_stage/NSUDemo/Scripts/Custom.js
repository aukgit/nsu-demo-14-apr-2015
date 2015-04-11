/// <reference path="_references.js" />

/// <reference path="wow.min.js" />
/// <reference path="angular.js" />
/// <reference path="angular.min.js" />
/// <reference path="bootstrap-datepicker.js" />
/// <reference path="bootstrap-datepicker.min.js" />
/// <reference path="bootstrap-timepicker.js" />
/// <reference path="bootstrap.js" />
/// <reference path="bootstrap.min.js" />
/// <reference path="Custom.js" />
/// <reference path="globalize-datepicker.js" />
/// <reference path="jquery-2.1.3.intellisense.js" />
/// <reference path="jquery.isotope.min.js" />
/// <reference path="jquery.unobtrusive-ajax.js" />
/// <reference path="jquery.unobtrusive-ajax.min.js" />
/// <reference path="jquery.validate-vsdoc.js" />
/// <reference path="jquery.validate.js" />
/// <reference path="jquery.validate.min.js" />
/// <reference path="jquery.validate.unobtrusive.js" />
/// <reference path="jquery.validate.unobtrusive.min.js" />
/// <reference path="knockout-3.2.0.debug.js" />
/// <reference path="knockout-3.2.0.js" />
/// <reference path="less-1.4.1.min.js" />
/// <reference path="markdown.js" />
/// <reference path="MarkdownDeepLib.min.js" />
/// <reference path="mdd_help.htm" />
/// <reference path="modernizr-2.8.3.js" />
/// <reference path="moment-with-locales.js" />
/// <reference path="moment-with-locales.min.js" />
/// <reference path="moment.js" />
/// <reference path="moment.min.js" />
/// <reference path="npm.js" />
/// <reference path="owl.carousel.min.js" />
/// <reference path="respond.js" />
/// <reference path="respond.matchmedia.addListener.js" />
/// <reference path="respond.matchmedia.addListener.min.js" />
/// <reference path="respond.min.js" />
/// <reference path="toastr.js" />
/// <reference path="toastr.min.js" />
/// <reference path="validation.js" />
/// <reference path="WebApiTestClient.js" />
/// <reference path="angular-mocks.js" />
/// <reference path="greenshock/TweenMax.js" />

$(function () {
    /*-----------------------------------------------------------------------------------*/
    /* 	ANIMATION
    /*-----------------------------------------------------------------------------------*/
    var wow = new WOW({
        boxClass: 'wow',      // animated element css class (default is wow)
        animateClass: 'animated', // animation css class (default is animated)
        offset: 100,          // distance to the element when triggering the animation (default is 0)
        mobile: false        // trigger animations on mobile devices (true is default)
    });
    wow.init();

    //TweenLite.to("div", .5, { opacity: .5 });
    //TweenLite.to(".jumbotron", .5, { width:"100px" });
});
