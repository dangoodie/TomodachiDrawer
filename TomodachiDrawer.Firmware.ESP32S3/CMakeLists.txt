cmake_minimum_required(VERSION 3.16)

# Skip components we don't use. ESP-IDF auto-includes everything in its tree;
# trimming the unused ones cuts the build from ~1050 to ~600 object files.
#   esp_lcd       - we don't drive displays. Bonus: GCC 15.2 in IDF v6.0.1's
#                   xtensa toolchain ICEs while compiling esp_lcd_panel_rgb.c
#                   anyway.
#   Everything else here is network/wireless/HTTP machinery that has no role
#   in a wired-USB-HID firmware.
set(EXCLUDE_COMPONENTS
    esp_lcd
    esp_wifi
    bt
    esp_eth
    esp_coex
    esp_netif
    esp_netif_stack
    lwip
    wpa_supplicant
    esp_http_client
    esp_http_server
    esp_https_ota
    esp_https_server
    esp-tls
    mqtt
    mdns
    protocomm
    wifi_provisioning
    esp_local_ctrl
    esp_hid
    ieee802154
)

include($ENV{IDF_PATH}/tools/cmake/project.cmake)

project(TomodachiDrawer_FW_ESP32S3)
