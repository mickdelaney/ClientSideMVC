require.config({
    baseUrl: "/Client",
    paths: {
        vendor: 'Vendor'
    }
});

define('core', ['jquery', 'Vendor/bootstrap/js/bootstrap', 'Vendor/moment'],
function ($) {
    return $;
});
