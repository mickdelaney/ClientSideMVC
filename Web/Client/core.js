require.config({
    baseUrl: "/cassette.axd/asset/Client",
    paths: {
        vendor: 'Vendor'
    }
});

define('core', ['jquery', 'Vendor/bootstrap/js/bootstrap', 'Vendor/moment'],
function ($) {
    return $;
});
