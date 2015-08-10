S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: watchdog
PID: 24578
Date: 2015-08-08 04:13:32+0530
Executable File Path: /opt/usr/apps/org.tizen.watchdog/bin/watchdog
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 24578, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xbe82caa4
r2   = 0x00000000, r3   = 0xbe82cac0
r4   = 0xb9024f30, r5   = 0x00000000
r6   = 0x00000000, r7   = 0xbe82cab8
r8   = 0x00000000, r9   = 0x00000002
r10  = 0xb6b589dc, fp   = 0xb6b589dc
ip   = 0xb4ce0854, sp   = 0xbe82ca28
lr   = 0xb6db7d1f, pc   = 0xb6db7c44
cpsr = 0xa0000030

Memory Information
MemTotal:   730748 KB
MemFree:     52464 KB
Buffers:     27508 KB
Cached:     171692 KB
VmPeak:     268092 KB
VmSize:     145384 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22860 KB
VmRSS:       22856 KB
VmData:      75112 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       30960 KB
VmPTE:         102 KB
VmSwap:        272 KB

Threads Information
Threads: 5
PID = 24578 TID = 24578
24578 24581 24582 24585 24587 

Maps Information
b1279000 b1287000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b12a5000 b12da000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
b12e3000 b12e4000 r-xp /usr/lib/libbincfg.so.1.1
b12ec000 b1332000 r-xp /usr/lib/libcamera-interface-sprd-sc7727.so.0.0.0
b1342000 b138a000 r-xp /usr/lib/libcamerahal.so.0.0.0
b1398000 b13a2000 r-xp /usr/lib/gstreamer-0.10/libgstevasimagesink.so
b13aa000 b13c0000 r-xp /usr/lib/gstreamer-0.10/libgstcamerasrc.so
b1bc9000 b23c8000 rw-p [stack:24587]
b2bd6000 b2bd7000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b2c85000 b3484000 rw-p [stack:24585]
b3499000 b349a000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b34a2000 b34b9000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3660000 b3664000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b366e000 b3e6d000 rw-p [stack:24581]
b3e6d000 b3fb4000 r-xp /usr/lib/driver/libMali.so
b3fc1000 b408b000 r-xp /usr/lib/libCOREGL.so.4.0
b409c000 b409f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b40a7000 b40aa000 r-xp /usr/lib/libEGL.so.1.4
b40b2000 b40c0000 r-xp /usr/lib/libGLESv2.so.2.0
b40c9000 b4119000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b435f000 b4373000 r-xp /usr/lib/libnetwork.so.0.0.0
b437b000 b4384000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.26
b438c000 b438e000 r-xp /usr/lib/libdevice_info.so.0.0.2
b4396000 b4398000 r-xp /usr/lib/libcryptsvc.so.0.0.2
b43a0000 b43bc000 r-xp /usr/lib/libdrm-service-core-tizen.so.0.3.9
b43d3000 b43da000 r-xp /usr/lib/libminizip.so.1.0.0
b43e2000 b43e4000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b43ec000 b43f3000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b43fc000 b4418000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b4421000 b4427000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b442f000 b4440000 r-xp /lib/libnsl-2.13.so
b444b000 b4453000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.55
b445b000 b445c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b4464000 b447f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4487000 b448c000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b4494000 b449c000 r-xp /usr/lib/libpims-ipc.so.0.1.18
b44a4000 b4505000 r-xp /usr/lib/libasound.so.2.0.0
b450f000 b4513000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b451b000 b451e000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b4527000 b4529000 r-xp /usr/lib/libemail-network.so.1.1.0
b4531000 b4535000 r-xp /usr/lib/libstorage.so.0.1
b453d000 b4573000 r-xp /usr/lib/libgmime-2.6.so.0.600.15
b458e000 b46cd000 r-xp /usr/lib/libicui18n.so.51.1
b46dd000 b46e1000 r-xp /usr/lib/libbadge.so.0.0.1
b46e9000 b46f0000 r-xp /usr/lib/libfeedback.so.0.1.4
b4704000 b4710000 r-xp /usr/lib/libalarm.so.0.0.0
b4719000 b472c000 r-xp /usr/lib/libaccounts-svc.so.0.2.97
b4734000 b4778000 r-xp /usr/lib/libcontacts-service2.so.0.12.54
b4783000 b482d000 r-xp /usr/lib/libuw-imap-toolkit.so.0.0.0
b483a000 b483e000 r-xp /usr/lib/libss-client.so.1.0.0
b4846000 b484f000 r-xp /usr/lib/libmdm-common.so.1.0.45
b4857000 b489f000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b48a0000 b48a6000 r-xp /usr/lib/libjson.so.0.1.0
b48ae000 b48b6000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b48c5000 b48c7000 r-xp /usr/lib/libiniparser.so.0
b48d1000 b48e7000 r-xp /usr/lib/lib_SamsungRec_TizenV04009.so
b4915000 b4918000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b4920000 b4936000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b493e000 b4942000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b494b000 b498e000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b4996000 b49a3000 r-xp /usr/lib/libemail-common-use.so.1.1.0
b49ab000 b4a17000 r-xp /usr/lib/libemail-core.so.1.1.0
b4a28000 b4a64000 r-xp /usr/lib/libemail-storage.so.1.1.0
b4a6d000 b4a76000 r-xp /usr/lib/libemail-ipc.so.1.1.0
b4a7e000 b4a80000 r-xp /usr/lib/libdri2.so.0.0.0
b4a88000 b4a8f000 r-xp /usr/lib/libdrm.so.2.4.0
b4a98000 b4a9c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4aa5000 b4ab8000 r-xp /usr/lib/libmdm.so.1.0.88
b4ac0000 b4ac6000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b4acf000 b4ad9000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b4ae5000 b4aed000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4af5000 b4af7000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
b4aff000 b4b36000 r-xp /usr/lib/libpulse.so.0.16.2
b4b3f000 b4b44000 r-xp /usr/lib/libmmfsession.so.0.0.0
b4b4c000 b4b61000 r-xp /usr/lib/libmmfsound.so.0.1.0
b4b69000 b4b6c000 r-xp /usr/lib/libmm_ta.so.0.0.0
b4b74000 b4b7d000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b4b85000 b4b92000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b4b9b000 b4ba4000 r-xp /usr/lib/libcom-core.so.0.0.1
b4bac000 b4bbc000 r-xp /usr/lib/libemail-api.so.1.1.0
b4bc4000 b4bcb000 r-xp /usr/lib/libtbm.so.1.0.0
b4bd3000 b4c6e000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b4c7a000 b4c7f000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4c87000 b4cd8000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b4ce6000 b4cea000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.3
b4cf2000 b4cf4000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4cfc000 b4d09000 r-xp /usr/lib/libnotification.so.0.1.0
b4d11000 b4d21000 r-xp /usr/lib/libcapi-media-camera.so.0.1.71
b4d2b000 b4d35000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4d3e000 b4d44000 r-xp /opt/usr/apps/org.tizen.watchdog/bin/watchdog
b4d4f000 b4d59000 r-xp /lib/libnss_files-2.13.so
b4d62000 b4d74000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4d7c000 b4d92000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4d9a000 b4e68000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4e7f000 b4ea3000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4eac000 b4eb2000 r-xp /usr/lib/libappsvc.so.0.1.0
b4eba000 b4ec8000 r-xp /usr/lib/libail.so.0.1.0
b4ed0000 b4ed2000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b4edb000 b4ee0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b4ee8000 b4eea000 r-xp /usr/lib/libcapi-messaging-email.so.0.1.24
b4ef3000 b4ef4000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4efd000 b4f01000 r-xp /usr/lib/libogg.so.0.7.1
b4f09000 b4f2b000 r-xp /usr/lib/libvorbis.so.0.4.3
b4f33000 b5017000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b502b000 b505c000 r-xp /usr/lib/libFLAC.so.8.2.0
b59f6000 b5a8a000 r-xp /usr/lib/libstdc++.so.6.0.16
b5a9d000 b5a9f000 r-xp /usr/lib/libXau.so.6.0.0
b5aa7000 b5ab1000 r-xp /usr/lib/libspdy.so.0.0.0
b5aba000 b5b06000 r-xp /usr/lib/libssl.so.1.0.0
b5b13000 b5b41000 r-xp /usr/lib/libidn.so.11.5.44
b5b49000 b5b53000 r-xp /usr/lib/libcares.so.2.1.0
b5b5b000 b5b7c000 r-xp /usr/lib/libexif.so.12.3.3
b5b8f000 b5bd4000 r-xp /usr/lib/libsndfile.so.1.0.25
b5be2000 b5bf8000 r-xp /lib/libexpat.so.1.5.2
b5c01000 b5ce6000 r-xp /usr/lib/libicuuc.so.51.1
b5cfb000 b5d2f000 r-xp /usr/lib/libicule.so.51.1
b5d38000 b5d4b000 r-xp /usr/lib/libxcb.so.1.1.0
b5d53000 b5d90000 r-xp /usr/lib/libcurl.so.4.3.0
b5d99000 b5da2000 r-xp /usr/lib/libethumb.so.1.7.99
b5dab000 b5dad000 r-xp /usr/lib/libctxdata.so.0.0.0
b5db5000 b5dc2000 r-xp /usr/lib/libremix.so.0.0.0
b5dca000 b5dcb000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5dd3000 b5dea000 r-xp /usr/lib/liblua-5.1.so
b5df3000 b5dfa000 r-xp /usr/lib/libembryo.so.1.7.99
b5e02000 b5e25000 r-xp /usr/lib/libjpeg.so.8.0.2
b5e3d000 b5e93000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5ea0000 b5ef3000 r-xp /usr/lib/libfreetype.so.6.8.1
b5efe000 b5f26000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5f27000 b5f6d000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5f76000 b5f89000 r-xp /usr/lib/libfribidi.so.0.3.1
b5f91000 b5f94000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5f9c000 b5fa0000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5fa8000 b5fad000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5fb6000 b5fc0000 r-xp /usr/lib/libXext.so.6.4.0
b5fc8000 b60a9000 r-xp /usr/lib/libX11.so.6.3.0
b60b4000 b60b7000 r-xp /usr/lib/libXtst.so.6.1.0
b60bf000 b60c5000 r-xp /usr/lib/libXrender.so.1.3.0
b60cd000 b60d2000 r-xp /usr/lib/libXrandr.so.2.2.0
b60da000 b60db000 r-xp /usr/lib/libXinerama.so.1.0.0
b60e4000 b60ec000 r-xp /usr/lib/libXi.so.6.1.0
b60ed000 b60f0000 r-xp /usr/lib/libXfixes.so.3.1.0
b60f8000 b60fa000 r-xp /usr/lib/libXgesture.so.7.0.0
b6102000 b6104000 r-xp /usr/lib/libXcomposite.so.1.0.0
b610c000 b610d000 r-xp /usr/lib/libXdamage.so.1.1.0
b6116000 b611c000 r-xp /usr/lib/libXcursor.so.1.0.2
b6125000 b613e000 r-xp /usr/lib/libecore_con.so.1.7.99
b6148000 b614e000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6156000 b615e000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6166000 b616f000 r-xp /usr/lib/libedbus.so.1.7.99
b6177000 b61d4000 r-xp /usr/lib/libedje.so.1.7.99
b61dd000 b61ee000 r-xp /usr/lib/libecore_input.so.1.7.99
b61f6000 b61fb000 r-xp /usr/lib/libecore_file.so.1.7.99
b6203000 b621c000 r-xp /usr/lib/libeet.so.1.7.99
b622d000 b6231000 r-xp /usr/lib/libappcore-common.so.1.1
b6239000 b6300000 r-xp /usr/lib/libevas.so.1.7.99
b6325000 b6346000 r-xp /usr/lib/libecore_evas.so.1.7.99
b634f000 b637e000 r-xp /usr/lib/libecore_x.so.1.7.99
b6388000 b64bf000 r-xp /usr/lib/libelementary.so.1.7.99
b64d5000 b64d6000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b64de000 b64e2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b64ed000 b64f0000 r-xp /lib/libgpg-error.so.0.5.0
b64f8000 b6550000 r-xp /usr/lib/libgcrypt.so.11.5.3
b655a000 b6586000 r-xp /usr/lib/libsystemd.so.0.0.1
b658f000 b6591000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b659a000 b6665000 r-xp /usr/lib/libxml2.so.2.7.8
b6673000 b6683000 r-xp /lib/libresolv-2.13.so
b6687000 b669d000 r-xp /lib/libz.so.1.2.5
b66a5000 b66a7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b66af000 b66b4000 r-xp /usr/lib/libffi.so.5.0.10
b66bd000 b66be000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b66c6000 b66c9000 r-xp /lib/libattr.so.1.1.0
b66d1000 b66d4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b66dc000 b66e3000 r-xp /usr/lib/libvconf.so.0.2.45
b66ec000 b6894000 r-xp /usr/lib/libcrypto.so.1.0.0
b68b5000 b68cb000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b68d3000 b693c000 r-xp /lib/libm-2.13.so
b6945000 b6985000 r-xp /usr/lib/libeina.so.1.7.99
b698e000 b69c2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b69cb000 b6a9f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6aab000 b6ab0000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6ab9000 b6abf000 r-xp /lib/librt-2.13.so
b6ac8000 b6acf000 r-xp /lib/libcrypt-2.13.so
b6aff000 b6b02000 r-xp /lib/libcap.so.2.21
b6b0a000 b6b0c000 r-xp /usr/lib/libiri.so
b6b14000 b6b33000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b3b000 b6b51000 r-xp /usr/lib/libecore.so.1.7.99
b6b67000 b6b6c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b75000 b6b8c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6b95000 b6ba0000 r-xp /lib/libunwind.so.8.0.1
b6bcd000 b6ce8000 r-xp /lib/libc-2.13.so
b6cf6000 b6cfe000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d06000 b6d30000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6d39000 b6d3c000 r-xp /usr/lib/libbundle.so.0.1.22
b6d44000 b6d46000 r-xp /lib/libdl-2.13.so
b6d4f000 b6d52000 r-xp /usr/lib/libsmack.so.1.0.0
b6d5a000 b6e2a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6e2b000 b6e90000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e9a000 b6eac000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eb4000 b6ec8000 r-xp /lib/libpthread-2.13.so
b6ed3000 b6ed5000 r-xp /usr/lib/libdlog.so.0.0.0
b6edd000 b6ee8000 r-xp /usr/lib/libaul.so.0.1.0
b6ef6000 b6ef9000 rw-p [stack:24582]
b6efa000 b6efd000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f07000 b6f0b000 r-xp /usr/lib/libsys-assert.so
b6f14000 b6f31000 r-xp /lib/ld-2.13.so
b6f3a000 b6f3f000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b8d97000 b8dc1000 rw-p [heap]
b8dc1000 b91ce000 rw-p [heap]
be80d000 be82e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24578)
Call Stack Count: 23
 0: (0xb6db7c44) [/usr/lib/libglib-2.0.so.0] + 0x5dc44
 1: g_mutex_lock + 0x6 (0xb6db7d1f) [/usr/lib/libglib-2.0.so.0] + 0x5dd1f
 2: _mmcamcorder_get_state + 0x10 (0xb4c95a4d) [/usr/lib/libmmfcamcorder.so.0] + 0xea4d
 3: mm_camcorder_get_state + 0xc (0xb4c94645) [/usr/lib/libmmfcamcorder.so.0] + 0xd645
 4: camera_get_state + 0x1e (0xb4d189e7) [/usr/lib/libcapi-media-camera.so.0] + 0x79e7
 5: _main_view_stop_camera_preview + 0x1a (0xb4d409f7) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x29f7
 6: _main_view_pause_cb + 0x36 (0xb4d40eeb) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x2eeb
 7: evas_object_smart_callback_call + 0x88 (0xb626e45d) [/usr/lib/libevas.so.1] + 0x3545d
 8: _app_pause_cb + 0x58 (0xb4d43079) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x5079
 9: (0xb64dfcf1) [/usr/lib/libcapi-appfw-application.so.0] + 0x1cf1
10: (0xb6efbec9) [/usr/lib/libappcore-efl.so.1] + 0x1ec9
11: (0xb6efc129) [/usr/lib/libappcore-efl.so.1] + 0x2129
12: (0xb6b42c6b) [/usr/lib/libecore.so.1] + 0x7c6b
13: (0xb6b46283) [/usr/lib/libecore.so.1] + 0xb283
14: ecore_main_loop_begin + 0x30 (0xb6b46691) [/usr/lib/libecore.so.1] + 0xb691
15: appcore_efl_main + 0x17e (0xb6efc387) [/usr/lib/libappcore-efl.so.1] + 0x2387
16: ui_app_main + 0xb0 (0xb64e0499) [/usr/lib/libcapi-appfw-application.so.0] + 0x2499
17: app_run + 0x4e (0xb4d42e8f) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x4e8f
18: main + 0x26 (0xb4d4322f) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x522f
19: _main_view_timer_cb + 0x46 (0xb6f3cdc7) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x2dc7
20: (0xb6f3bd8f) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x1d8f
21: __libc_start_main + 0x114 (0xb6be482c) [/lib/libc.so.6] + 0x1782c
22: (0xb6f3c0d4) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x20d4
End of Call Stack

Package Information
Package Name: org.tizen.watchdog
Package ID : org.tizen.watchdog
Version: 1.0.0
Package Type: rpm
App Name: WatchDog
App ID: org.tizen.watchdog
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
)
08-08 04:13:20.606+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(1520) > User.Email.NetworkStatus
08-08 04:13:20.606+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(1556) > NOTI_DOWNLOAD_FINISH
08-08 04:13:20.606+0530 I/EMAIL_COMM(24009): email-utils.c: _generate_best_pattern(1607) > bestPatternLength: 6
08-08 04:13:20.606+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_cb(884) > Ecore_Thread(0xb8d47390)
08-08 04:13:20.616+0530 I/EMAIL_MBOX(24009): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(361), preview_len(75)
08-08 04:13:20.636+0530 I/EMAIL_MBOX(24009): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(359), preview_len(75)
08-08 04:13:20.636+0530 I/EMAIL_COMM(24009): email-utils.c: _generate_best_pattern(1627) > formattedLength: 7
08-08 04:13:20.646+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _check_req_handle_list(1935) > handle(2), g_req_handle_list((nil))
08-08 04:13:20.646+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _check_req_handle_list(1941) > handle_count(0)
08-08 04:13:20.646+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _check_req_handle_list(1951) > handle_count(0)
08-08 04:13:20.646+0530 I/EMAIL_MBOX(24009): email-mailbox-list-other-items.c: mailbox_load_more_messages_item_add(831) > get_more_messages item already exist.
08-08 04:13:20.646+0530 I/EMAIL_MBOX(24009): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(354), preview_len(75)
08-08 04:13:20.656+0530 I/EMAIL_MBOX(24009): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(356), preview_len(75)
08-08 04:13:20.696+0530 I/AUL     (23889): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/email-service, ret : 0
08-08 04:13:20.706+0530 I/AUL     (23889): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/email-service, ret : 0
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 20010, data1: 1, data2: 3, data3: , data4: 0
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(324) > NOTI_ACCOUNT_UPDATE_SYNC_STATUS
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 20010, data1: 1, data2: 2, data3: , data4: 0
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(324) > NOTI_ACCOUNT_UPDATE_SYNC_STATUS
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb8d47390)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(361) mail_id(361) info(0xb8c4d448)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 45
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb8d47390)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb8c54220)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(359) mail_id(359) info(0xb8d53ea0)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 46
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb8c54220)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb8cb5e28)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(356) mail_id(356) info(0xb8e68a80)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 47
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb8cb5e28)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb8d491e8)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(354) mail_id(354) info(0xb8ed57f8)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
08-08 04:13:20.746+0530 I/EMAIL_MBOX(24009): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 48
08-08 04:13:20.756+0530 I/EMAIL_MBOX(24009): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(357), preview_len(75)
08-08 04:13:20.756+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb8d491e8)
08-08 04:13:20.826+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb8d2a210)
08-08 04:13:20.826+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(357) mail_id(357) info(0xb8d401e8)
08-08 04:13:20.826+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
08-08 04:13:20.826+0530 I/EMAIL_MBOX(24009): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
08-08 04:13:20.826+0530 I/EMAIL_MBOX(24009): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 49
08-08 04:13:20.826+0530 I/EMAIL_MBOX(24009): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb8d2a210)
08-08 04:13:21.176+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:13:21.176+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:13:21.176+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:13:21.176+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:13:21.176+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:13:21.176+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:13:21.176+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:13:21.176+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:13:21.176+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:13:21.176+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:13:21.186+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:13:21.336+0530 I/CAPI_APPFW_APPLICATION(23942): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:21.336+0530 I/CAPI_APPFW_APPLICATION( 9718): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:21.336+0530 I/CAPI_APPFW_APPLICATION(22405): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:21.336+0530 I/CAPI_APPFW_APPLICATION( 3387): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:21.336+0530 W/CAM_APP ( 9718): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-08 04:13:21.396+0530 I/CAPI_APPFW_APPLICATION(22405): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:21.396+0530 I/CAPI_APPFW_APPLICATION(23942): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:21.396+0530 I/CAPI_APPFW_APPLICATION( 9718): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:21.396+0530 I/CAPI_APPFW_APPLICATION( 3387): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:21.396+0530 W/CAM_APP ( 9718): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-08 04:13:22.216+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:13:22.356+0530 I/CAPI_APPFW_APPLICATION(23942): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:22.356+0530 I/CAPI_APPFW_APPLICATION(22405): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:22.356+0530 I/CAPI_APPFW_APPLICATION( 9718): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:22.356+0530 I/CAPI_APPFW_APPLICATION( 3387): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:22.356+0530 W/CAM_APP ( 9718): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-08 04:13:22.946+0530 E/TIZEN_N_CAMERA(23942): camera.c: camera_stop_face_detection(1250) > NOT SUPPORTED
08-08 04:13:23.046+0530 W/TIZEN_N_CAMERA(23942): camera.c: camera_destroy(844) > camera handle 0xb90bfd30
08-08 04:13:23.056+0530 I/TIZEN_N_CAMERA(23942): camera.c: _camera_remove_cb_message(92) > start
08-08 04:13:23.056+0530 W/TIZEN_N_CAMERA(23942): camera.c: _camera_remove_cb_message(118) > There is no remained callback
08-08 04:13:23.056+0530 I/TIZEN_N_CAMERA(23942): camera.c: _camera_remove_cb_message(123) > done
08-08 04:13:23.266+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:13:23.266+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:13:23.266+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:13:23.266+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:13:23.266+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:13:23.266+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:13:23.266+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:13:23.266+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:13:23.266+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:13:23.266+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:13:23.266+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:13:23.496+0530 I/CAPI_APPFW_APPLICATION(23942): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:23.496+0530 I/CAPI_APPFW_APPLICATION(22405): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:23.496+0530 I/CAPI_APPFW_APPLICATION( 9718): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:23.496+0530 I/CAPI_APPFW_APPLICATION( 3387): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:23.496+0530 W/CAM_APP ( 9718): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-08 04:13:24.166+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 322, data3: , data4: 14
08-08 04:13:24.166+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:24.436+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 321, data3: , data4: 14
08-08 04:13:24.436+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:24.446+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 320, data3: , data4: 14
08-08 04:13:24.446+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:24.446+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 319, data3: , data4: 14
08-08 04:13:24.446+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:24.456+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:13:24.516+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 318, data3: , data4: 14
08-08 04:13:24.516+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:24.586+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 317, data3: , data4: 14
08-08 04:13:24.586+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:24.856+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 316, data3: , data4: 14
08-08 04:13:24.856+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:24.936+0530 I/CAPI_APPFW_APPLICATION(23942): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:24.936+0530 I/CAPI_APPFW_APPLICATION(22405): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:24.936+0530 I/CAPI_APPFW_APPLICATION( 9718): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:24.936+0530 I/CAPI_APPFW_APPLICATION( 3387): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:24.936+0530 W/CAM_APP ( 9718): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-08 04:13:24.976+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:13:25.056+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 315, data3: , data4: 14
08-08 04:13:25.056+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:25.056+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 314, data3: , data4: 14
08-08 04:13:25.056+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:25.066+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:13:25.106+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationVirtual) step(-21) failed(2 / No such file or directory)
08-08 04:13:25.106+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationVirtual : read buf error(-21). break
08-08 04:13:25.106+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationVirtual error
08-08 04:13:25.116+0530 E/CAPI_LOCATION_MANAGER(  939): location_product.c: _location_manager_gps_state_cb(102) > _location_manager_gps_state_cb
08-08 04:13:25.116+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] gps 0!"
08-08 04:13:25.116+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(726) > "Pack to SYSTEM list : gps"
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationTest) step(-21) failed(2 / No such file or directory)
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationTest : read buf error(-21). break
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationTest error
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationVirtual) step(-21) failed(2 / No such file or directory)
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationVirtual : read buf error(-21). break
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationVirtual error
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationVirtual) step(-21) failed(2 / No such file or directory)
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationVirtual : read buf error(-21). break
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationVirtual error
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/QoP/DynamicAcc) step(-21) failed(2 / No such file or directory)
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/QoP/DynamicAcc : read buf error(-21). break
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/QoP/DynamicAcc error
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/QoP/Timeout) step(-21) failed(2 / No such file or directory)
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/QoP/Timeout : read buf error(-21). break
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/QoP/Timeout error
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/QoP/Accuracy) step(-21) failed(2 / No such file or directory)
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/QoP/Accuracy : read buf error(-21). break
08-08 04:13:25.116+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/QoP/Accuracy error
08-08 04:13:25.116+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-08 04:13:25.116+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-08 04:13:25.116+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-08 04:13:25.116+0530 I/indicator(  508): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
08-08 04:13:25.116+0530 I/EFL-ASSIST(  508): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 1d3d398 (elm_image), color code: AO004, color [255, 255, 255, 255]
08-08 04:13:25.116+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : gps 418 0 28 36"
08-08 04:13:25.116+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-08 04:13:25.116+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 375 303 5 28 25"
08-08 04:13:25.116+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 331 5 28 25"
08-08 04:13:25.116+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
08-08 04:13:25.116+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] gps 1!"
08-08 04:13:25.116+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(726) > "Pack to SYSTEM list : gps"
08-08 04:13:25.126+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 313, data3: , data4: 14
08-08 04:13:25.126+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:25.126+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-08 04:13:25.126+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-08 04:13:25.126+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-08 04:13:25.126+0530 I/indicator(  508): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
08-08 04:13:25.126+0530 I/EFL-ASSIST(  508): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: b08df898 (elm_image), color code: AO004, color [255, 255, 255, 255]
08-08 04:13:25.126+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : gps 738 0 28 36"
08-08 04:13:25.126+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-08 04:13:25.126+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 343 623 5 28 25"
08-08 04:13:25.126+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 375 651 5 28 25"
08-08 04:13:25.126+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 679 5 28 25"
08-08 04:13:25.126+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
08-08 04:13:25.136+0530 I/indicator(  508): indicator_box_util.c: indicator_is_enable_to_insert_in_non_fixed_list(1697) > "[CAN_ADD_WITHOUT_DEL]"
08-08 04:13:25.136+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] more_notify 0!"
08-08 04:13:25.136+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(772) > "Pack to NOTI list : more_notify"
08-08 04:13:25.136+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-08 04:13:25.136+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-08 04:13:25.136+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-08 04:13:25.136+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : gps 418 0 28 36"
08-08 04:13:25.136+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-08 04:13:25.136+0530 I/indicator(  508): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
08-08 04:13:25.136+0530 I/EFL-ASSIST(  508): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: b08dda58 (elm_image), color code: AO004, color [255, 255, 255, 255]
08-08 04:13:25.136+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 0 0 0 0"
08-08 04:13:25.136+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 331 5 28 25"
08-08 04:13:25.136+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
08-08 04:13:25.436+0530 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-08 04:13:25.436+0530 W/AUL_AMD (  455): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-08 04:13:25.496+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:13:25.496+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:13:25.496+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:13:25.496+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:13:25.496+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:13:25.496+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:13:25.496+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:13:25.496+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:13:25.496+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:13:25.496+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:13:25.496+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:13:25.516+0530 I/MALI    (23942): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb8e612e8] swap changed from sync to async
08-08 04:13:25.526+0530 W/PROCESSMGR(  343): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=604
08-08 04:13:25.536+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-08 04:13:25.556+0530 I/indicator(  508): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 604"
08-08 04:13:25.556+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-08 04:13:25.576+0530 I/Tizen::System( 1120): (101) > Active App is com.samsung.homescreen. GetApp id ACL111OMWW.AclService
08-08 04:13:25.596+0530 I/CAPI_APPFW_APPLICATION(  604): app_main.c: app_appcore_resume(223) > app_appcore_resume
08-08 04:13:25.596+0530 E/cluster-home(  604): homescreen-main.cpp: app_resume(422) >  app resume
08-08 04:13:25.596+0530 I/CAPI_APPFW_APPLICATION(23942): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
08-08 04:13:25.616+0530 I/Tizen::System( 1053): (259) > Active app [com.samsun], current [org.tizen.] 
08-08 04:13:25.616+0530 I/Tizen::Io( 1053): (729) > Entry not found
08-08 04:13:25.626+0530 I/Tizen::System( 1053): (157) > change brightness system value.
08-08 04:13:26.096+0530 I/AUL_PAD (  504): sigchild.h: __launchpad_sig_child(142) > dead_pid = 23942 pgid = 23942
08-08 04:13:26.096+0530 I/AUL_PAD (  504): sigchild.h: __sigchild_action(123) > dead_pid(23942)
08-08 04:13:26.096+0530 I/AUL_PAD (  504): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-08 04:13:26.096+0530 I/AUL_PAD (  504): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-08 04:13:26.096+0530 I/AUL_AMD (  455): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 23942
08-08 04:13:26.096+0530 I/Tizen::System( 1053): (246) > Terminated app [org.tizen.watchdog]
08-08 04:13:26.096+0530 I/Tizen::Io( 1053): (729) > Entry not found
08-08 04:13:26.096+0530 I/Tizen::App(  999): (243) > App[org.tizen.watchdog] pid[23942] terminate event is forwarded
08-08 04:13:26.096+0530 I/Tizen::System(  999): (256) > osp.accessorymanager.service provider is found.
08-08 04:13:26.096+0530 I/Tizen::System(  999): (196) > Accessory Owner is removed [org.tizen.watchdog, 23942, ]
08-08 04:13:26.096+0530 I/Tizen::System(  999): (256) > osp.system.service provider is found.
08-08 04:13:26.096+0530 I/Tizen::App(  999): (506) > TerminatedApp(org.tizen.watchdog)
08-08 04:13:26.096+0530 I/Tizen::App(  999): (512) > Not registered pid(23942)
08-08 04:13:26.096+0530 I/Tizen::App(  999): (782) > Finished invoking application event listener for org.tizen.watchdog, 23942.
08-08 04:13:26.106+0530 I/Tizen::System( 1053): (157) > change brightness system value.
08-08 04:13:26.106+0530 I/Tizen::App( 1053): (782) > Finished invoking application event listener for org.tizen.watchdog, 23942.
08-08 04:13:26.186+0530 W/CRASH_MANAGER(24569): worker.c: worker_job(1236) > 11239427761741438987405
08-08 04:13:26.386+0530 E/VCONF   (  939): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
08-08 04:13:26.386+0530 E/VCONF   (  939): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
08-08 04:13:26.386+0530 E/VCONF   (  939): vconf.c: vconf_get_int(2379) > vconf_get_int(939) : file/private/wifi/always_allow_scanning error
08-08 04:13:26.386+0530 E/VCONF   (  939): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
08-08 04:13:26.386+0530 E/VCONF   (  939): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
08-08 04:13:26.386+0530 E/VCONF   (  939): vconf.c: vconf_get_int(2379) > vconf_get_int(939) : file/private/wifi/always_allow_scanning error
08-08 04:13:26.386+0530 I/RESOURCED(  837): swap.c: swap_send_signal(316) > [swap_send_signal,316] send signal to swap thread
08-08 04:13:26.386+0530 I/RESOURCED(  837): swap.c: swap_thread_main(281) > [swap_thread_main,281] swap thread conditional signal received
08-08 04:13:26.406+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-08 04:13:26.416+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-08 04:13:26.556+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:13:26.776+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 1
08-08 04:13:26.936+0530 I/CAPI_APPFW_APPLICATION(24578): app_main.c: ui_app_main(699) > app_efl_main
08-08 04:13:26.946+0530 I/CAPI_APPFW_APPLICATION( 3387): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:26.946+0530 I/CAPI_APPFW_APPLICATION( 9718): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:26.946+0530 I/CAPI_APPFW_APPLICATION(22405): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:13:26.946+0530 W/CAM_APP ( 9718): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-08 04:13:27.016+0530 E/RESOURCED(  837): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 259
08-08 04:13:27.026+0530 I/Tizen::App(  999): (499) > LaunchedApp(org.tizen.watchdog)
08-08 04:13:27.026+0530 I/Tizen::App(  999): (733) > Finished invoking application event listener for org.tizen.watchdog, 24578.
08-08 04:13:27.046+0530 I/Tizen::App( 1053): (733) > Finished invoking application event listener for org.tizen.watchdog, 24578.
08-08 04:13:27.086+0530 I/CAPI_APPFW_APPLICATION(24578): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
08-08 04:13:27.256+0530 I/Tizen::Net::Wifi( 1082): (928) > The background scan result updated.
08-08 04:13:27.256+0530 I/Tizen::Net::Wifi( 1082): (934) > Fire event [WIFI_EVENT_SCAN_COMPLETED]
08-08 04:13:27.506+0530 W/PROCESSMGR(  343): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=24578
08-08 04:13:27.526+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-08 04:13:27.536+0530 I/Tizen::System( 1120): (101) > Active App is org.tizen.watchdog. GetApp id ACL111OMWW.AclService
08-08 04:13:27.546+0530 I/CAPI_APPFW_APPLICATION(24578): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
08-08 04:13:27.546+0530 I/APP_CORE(24578): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
08-08 04:13:27.546+0530 I/APP_CORE(24578): appcore-efl.c: __do_app(511) > [APP 24578] Initial Launching, call the resume_cb
08-08 04:13:27.546+0530 I/CAPI_APPFW_APPLICATION(24578): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
08-08 04:13:27.556+0530 I/Tizen::System( 1053): (259) > Active app [org.tizen.], current [com.samsun] 
08-08 04:13:27.556+0530 I/Tizen::Io( 1053): (729) > Entry not found
08-08 04:13:27.556+0530 I/Tizen::System( 1053): (157) > change brightness system value.
08-08 04:13:27.596+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:13:27.596+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:13:27.596+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:13:27.596+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:13:27.596+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:13:27.596+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:13:27.596+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:13:27.596+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:13:27.596+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:13:27.596+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:13:27.596+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:13:27.646+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-08 04:13:27.656+0530 I/SECURE_STORAGE(  389): ss_server_ipc.c: SsServerComm(251) > write succeed
08-08 04:13:27.696+0530 E/EFL     (24578): evas_main<24578> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
08-08 04:13:27.706+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-08 04:13:27.706+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-08 04:13:27.716+0530 I/indicator(  508): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.watchdog, pid = 24578"
08-08 04:13:27.716+0530 E/EFL     (24578): evas_main<24578> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
08-08 04:13:27.796+0530 W/TIZEN_N_CAMERA(24578): camera.c: camera_create(764) > [camera_create]device name = [1]
08-08 04:13:27.866+0530 W/TIZEN_N_CAMERA(24578): camera.c: camera_create(824) > camera handle 0xb9027f68
08-08 04:13:27.866+0530 W/TIZEN_N_CAMERA(24578): camera.c: camera_start_preview(869) > camera_start_preview - start
08-08 04:13:28.636+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:13:28.686+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack_append(874) > "[icon_box_pack_append] 375!"
08-08 04:13:28.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-08 04:13:28.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-08 04:13:28.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-08 04:13:28.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 390 0 56 36"
08-08 04:13:28.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-08 04:13:28.686+0530 E/indicator(  508): indicator_icon_util.c: _img_icon_add(287) > _img_icon_add[287]	 "icon file does not exist!!: /opt/usr/apps/org.tizen.watchdog/shared/res/watchdog.png"
08-08 04:13:28.686+0530 I/indicator(  508): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
08-08 04:13:28.686+0530 I/EFL-ASSIST(  508): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 1d8e8b0 (elm_image), color code: AO004, color [255, 255, 255, 255]
08-08 04:13:28.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 375 0 0 0 0"
08-08 04:13:28.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 331 5 28 25"
08-08 04:13:28.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
08-08 04:13:28.686+0530 E/CAPI_LOCATION_MANAGER(  939): location_product.c: _location_manager_gps_state_cb(102) > _location_manager_gps_state_cb
08-08 04:13:28.696+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 332, data3: , data4: 14
08-08 04:13:28.696+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 710 0 56 36"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 343 595 5 28 25"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 375 623 5 28 25"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 651 5 28 25"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack_append(874) > "[icon_box_pack_append] 343!"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 390 0 56 36"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 375 0 0 0 0"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 331 5 28 25"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
08-08 04:13:28.706+0530 I/indicator(  508): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
08-08 04:13:28.706+0530 I/EFL-ASSIST(  508): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 1d8fa90 (elm_image), color code: AO004, color [255, 255, 255, 255]
08-08 04:13:28.706+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 343 0 0 0 0"
08-08 04:13:28.776+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 331, data3: , data4: 14
08-08 04:13:28.776+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:29.046+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 330, data3: , data4: 14
08-08 04:13:29.046+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:29.056+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 329, data3: , data4: 14
08-08 04:13:29.056+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:29.056+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 328, data3: , data4: 14
08-08 04:13:29.056+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:29.056+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 327, data3: , data4: 14
08-08 04:13:29.056+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:29.056+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 326, data3: , data4: 14
08-08 04:13:29.056+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:29.136+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 325, data3: , data4: 14
08-08 04:13:29.136+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:29.196+0530 E/TIZEN_N_CAMERA(24578): camera.c: __convert_camera_error_code(234) > [__camera_start_continuous_focusing] ERROR_NOT_SUPPORTED(0xc0000002) : core frameworks error code(0x80000107)
08-08 04:13:29.196+0530 I/camerasample(24578): Existing: (null)
08-08 04:13:29.246+0530 I/camerasample(24578): Inside Main view
08-08 04:13:29.366+0530 W/APP_CORE(24578): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00003
08-08 04:13:29.406+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 324, data3: , data4: 14
08-08 04:13:29.406+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:29.446+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 323, data3: , data4: 14
08-08 04:13:29.446+0530 I/EMAIL_MBOX(24009): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
08-08 04:13:29.476+0530 I/CAPI_APPFW_APPLICATION(  604): app_main.c: app_appcore_pause(202) > app_appcore_pause
08-08 04:13:29.476+0530 E/cluster-home(  604): homescreen-main.cpp: app_pause(355) >  app pause
08-08 04:13:29.496+0530 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-08 04:13:29.496+0530 W/AUL_AMD (  455): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-08 04:13:29.616+0530 W/TIZEN_N_CAMERA(24578): camera.c: __idle_cb(738) > user_cb[type 10] is NULL
08-08 04:13:29.746+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:13:29.756+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:13:29.756+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:13:29.756+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:13:29.756+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:13:29.756+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:13:29.756+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:13:29.756+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:13:29.756+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:13:29.756+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:13:29.756+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:13:30.796+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:13:31.416+0530 E/TIZEN_N_CAMERA(24578): camera.c: camera_stop_face_detection(1250) > NOT SUPPORTED
08-08 04:13:31.536+0530 W/TIZEN_N_CAMERA(24578): camera.c: camera_destroy(844) > camera handle 0xb9027f68
08-08 04:13:31.546+0530 I/TIZEN_N_CAMERA(24578): camera.c: _camera_remove_cb_message(92) > start
08-08 04:13:31.546+0530 W/TIZEN_N_CAMERA(24578): camera.c: _camera_remove_cb_message(118) > There is no remained callback
08-08 04:13:31.546+0530 I/TIZEN_N_CAMERA(24578): camera.c: _camera_remove_cb_message(123) > done
08-08 04:13:31.826+0530 I/MALI    (24578): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb8e612e0] swap changed from async to sync
08-08 04:13:31.836+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:13:31.836+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:13:31.836+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:13:31.836+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:13:31.836+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:13:31.836+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:13:31.836+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:13:31.836+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:13:31.836+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:13:31.836+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:13:31.836+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:13:31.976+0530 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-08 04:13:31.976+0530 W/AUL_AMD (  455): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-08 04:13:32.026+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-08 04:13:32.036+0530 I/indicator(  508): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 604"
08-08 04:13:32.066+0530 I/MALI    (24578): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb8e612e0] swap changed from sync to async
08-08 04:13:32.076+0530 W/PROCESSMGR(  343): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=604
08-08 04:13:32.136+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-08 04:13:32.146+0530 I/CAPI_APPFW_APPLICATION(  604): app_main.c: app_appcore_resume(223) > app_appcore_resume
08-08 04:13:32.146+0530 E/cluster-home(  604): homescreen-main.cpp: app_resume(422) >  app resume
08-08 04:13:32.166+0530 I/CAPI_APPFW_APPLICATION(24578): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
08-08 04:13:32.166+0530 I/Tizen::System( 1053): (259) > Active app [com.samsun], current [org.tizen.] 
08-08 04:13:32.166+0530 I/Tizen::Io( 1053): (729) > Entry not found
08-08 04:13:32.186+0530 I/Tizen::System( 1053): (157) > change brightness system value.
08-08 04:13:32.226+0530 I/Tizen::System( 1120): (101) > Active App is com.samsung.homescreen. GetApp id ACL111OMWW.AclService
08-08 04:13:32.306+0530 I/RESOURCED(  837): vmpressure-lowmem-handler.c: lowmem_swap_memory(1099) > [lowmem_swap_memory,1099] swap cgroup entered : pid : 24009
08-08 04:13:32.636+0530 W/CRASH_MANAGER(24569): worker.c: worker_job(1236) > 1124578776174143898741
