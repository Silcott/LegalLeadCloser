﻿if ('serviceWorker' in navigator) {
    navigator.serviceWorker.register('sw.js?v2', {
        scope: '.' // <--- THIS BIT IS REQUIRED
    }).then(function (registration) {
        // Registration was successful
        console.log('ServiceWorker registration successful with scope: ', registration.scope);
    }, function (err) {
        // registration failed :(
        console.log('ServiceWorker registration failed: ', err);
    });
}
self.addEventListener('fetch', () => console.log("fetch"));
