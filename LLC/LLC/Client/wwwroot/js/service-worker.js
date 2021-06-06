navigator.serviceWorker.register('/js/service-worker.js', { scope: '/' })
    .then(function (registration) {
        console.log('Service worker registered successfully');
    }).catch(function (e) {
        console.error('Error during service worker registration:', e);
    });