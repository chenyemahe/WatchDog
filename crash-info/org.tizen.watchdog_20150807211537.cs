S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: watchdog
PID: 9302
Date: 2015-08-07 21:15:37+0530
Executable File Path: /opt/usr/apps/org.tizen.watchdog/bin/watchdog
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9302, uid 5000)

Register Information
r0   = 0x00736575, r1   = 0xbe82caa4
r2   = 0x00000000, r3   = 0xbe82cac0
r4   = 0xb90c0ab0, r5   = 0x00736575
r6   = 0x00000000, r7   = 0xbe82cab8
r8   = 0x00000000, r9   = 0x00000002
r10  = 0xb6b589dc, fp   = 0xb6b589dc
ip   = 0xb4ce1854, sp   = 0xbe82ca28
lr   = 0xb6db7d1f, pc   = 0xb6db7c44
cpsr = 0xa0000030

Memory Information
MemTotal:   730748 KB
MemFree:     23416 KB
Buffers:     28900 KB
Cached:     269088 KB
VmPeak:     264040 KB
VmSize:     136876 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22376 KB
VmRSS:       22372 KB
VmData:      66624 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       30960 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 9302 TID = 9302
9302 9303 9304 9309 

Maps Information
b1a7a000 b1a88000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b1aa6000 b1adb000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
b1ae4000 b1ae5000 r-xp /usr/lib/libbincfg.so.1.1
b1aed000 b1b33000 r-xp /usr/lib/libcamera-interface-sprd-sc7727.so.0.0.0
b1b43000 b1b8b000 r-xp /usr/lib/libcamerahal.so.0.0.0
b1b99000 b1ba3000 r-xp /usr/lib/gstreamer-0.10/libgstevasimagesink.so
b1bab000 b1bc1000 r-xp /usr/lib/gstreamer-0.10/libgstcamerasrc.so
b23e6000 b2be5000 rw-p [stack:9309]
b33f3000 b33f4000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b349a000 b349b000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b34a3000 b34ba000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3661000 b3665000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b366f000 b3e6e000 rw-p [stack:9303]
b3e6e000 b3fb5000 r-xp /usr/lib/driver/libMali.so
b3fc2000 b408c000 r-xp /usr/lib/libCOREGL.so.4.0
b409d000 b40a0000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b40a8000 b40ab000 r-xp /usr/lib/libEGL.so.1.4
b40b3000 b40c1000 r-xp /usr/lib/libGLESv2.so.2.0
b40ca000 b411a000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b4360000 b4374000 r-xp /usr/lib/libnetwork.so.0.0.0
b437c000 b4385000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.26
b438d000 b438f000 r-xp /usr/lib/libdevice_info.so.0.0.2
b4397000 b4399000 r-xp /usr/lib/libcryptsvc.so.0.0.2
b43a1000 b43bd000 r-xp /usr/lib/libdrm-service-core-tizen.so.0.3.9
b43d4000 b43db000 r-xp /usr/lib/libminizip.so.1.0.0
b43e3000 b43e5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b43ed000 b43f4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b43fd000 b4419000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b4422000 b4428000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b4430000 b4441000 r-xp /lib/libnsl-2.13.so
b444c000 b4454000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.55
b445c000 b445d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b4465000 b4480000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4488000 b448d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b4495000 b449d000 r-xp /usr/lib/libpims-ipc.so.0.1.18
b44a5000 b4506000 r-xp /usr/lib/libasound.so.2.0.0
b4510000 b4514000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b451c000 b451f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b4528000 b452a000 r-xp /usr/lib/libemail-network.so.1.1.0
b4532000 b4536000 r-xp /usr/lib/libstorage.so.0.1
b453e000 b4574000 r-xp /usr/lib/libgmime-2.6.so.0.600.15
b458f000 b46ce000 r-xp /usr/lib/libicui18n.so.51.1
b46de000 b46e2000 r-xp /usr/lib/libbadge.so.0.0.1
b46ea000 b46f1000 r-xp /usr/lib/libfeedback.so.0.1.4
b4705000 b4711000 r-xp /usr/lib/libalarm.so.0.0.0
b471a000 b472d000 r-xp /usr/lib/libaccounts-svc.so.0.2.97
b4735000 b4779000 r-xp /usr/lib/libcontacts-service2.so.0.12.54
b4784000 b482e000 r-xp /usr/lib/libuw-imap-toolkit.so.0.0.0
b483b000 b483f000 r-xp /usr/lib/libss-client.so.1.0.0
b4847000 b4850000 r-xp /usr/lib/libmdm-common.so.1.0.45
b4858000 b48a0000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b48a1000 b48a7000 r-xp /usr/lib/libjson.so.0.1.0
b48af000 b48b7000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b48c6000 b48c8000 r-xp /usr/lib/libiniparser.so.0
b48d2000 b48e8000 r-xp /usr/lib/lib_SamsungRec_TizenV04009.so
b4916000 b4919000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b4921000 b4937000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b493f000 b4943000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b494c000 b498f000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b4997000 b49a4000 r-xp /usr/lib/libemail-common-use.so.1.1.0
b49ac000 b4a18000 r-xp /usr/lib/libemail-core.so.1.1.0
b4a29000 b4a65000 r-xp /usr/lib/libemail-storage.so.1.1.0
b4a6e000 b4a77000 r-xp /usr/lib/libemail-ipc.so.1.1.0
b4a7f000 b4a81000 r-xp /usr/lib/libdri2.so.0.0.0
b4a89000 b4a90000 r-xp /usr/lib/libdrm.so.2.4.0
b4a99000 b4a9d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4aa6000 b4ab9000 r-xp /usr/lib/libmdm.so.1.0.88
b4ac1000 b4ac7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b4ad0000 b4ada000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b4ae6000 b4aee000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4af6000 b4af8000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
b4b00000 b4b37000 r-xp /usr/lib/libpulse.so.0.16.2
b4b40000 b4b45000 r-xp /usr/lib/libmmfsession.so.0.0.0
b4b4d000 b4b62000 r-xp /usr/lib/libmmfsound.so.0.1.0
b4b6a000 b4b6d000 r-xp /usr/lib/libmm_ta.so.0.0.0
b4b75000 b4b7e000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b4b86000 b4b93000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b4b9c000 b4ba5000 r-xp /usr/lib/libcom-core.so.0.0.1
b4bad000 b4bbd000 r-xp /usr/lib/libemail-api.so.1.1.0
b4bc5000 b4bcc000 r-xp /usr/lib/libtbm.so.1.0.0
b4bd4000 b4c6f000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b4c7b000 b4c80000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4c88000 b4cd9000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b4ce7000 b4ceb000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.3
b4cf3000 b4cf5000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4cfd000 b4d0a000 r-xp /usr/lib/libnotification.so.0.1.0
b4d12000 b4d22000 r-xp /usr/lib/libcapi-media-camera.so.0.1.71
b4d2c000 b4d36000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4d3f000 b4d45000 r-xp /opt/usr/apps/org.tizen.watchdog/bin/watchdog
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
b6ef6000 b6ef9000 rw-p [stack:9304]
b6efa000 b6efd000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f07000 b6f0b000 r-xp /usr/lib/libsys-assert.so
b6f14000 b6f31000 r-xp /lib/ld-2.13.so
b6f3a000 b6f3f000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b8d97000 b8de0000 rw-p [heap]
b8de0000 b9282000 rw-p [heap]
be80d000 be82e000 rw-p [stack]
be80d000 be82e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9302)
Call Stack Count: 23
 0: (0xb6db7c44) [/usr/lib/libglib-2.0.so.0] + 0x5dc44
 1: g_mutex_lock + 0x6 (0xb6db7d1f) [/usr/lib/libglib-2.0.so.0] + 0x5dd1f
 2: _mmcamcorder_get_state + 0x10 (0xb4c96a4d) [/usr/lib/libmmfcamcorder.so.0] + 0xea4d
 3: mm_camcorder_get_state + 0xc (0xb4c95645) [/usr/lib/libmmfcamcorder.so.0] + 0xd645
 4: camera_get_state + 0x1e (0xb4d199e7) [/usr/lib/libcapi-media-camera.so.0] + 0x79e7
 5: _main_view_stop_camera_preview + 0x1a (0xb4d41893) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x2893
 6: _main_view_pause_cb + 0x36 (0xb4d41d83) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x2d83
 7: evas_object_smart_callback_call + 0x88 (0xb626e45d) [/usr/lib/libevas.so.1] + 0x3545d
 8: _app_pause_cb + 0x58 (0xb4d43d7d) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x4d7d
 9: (0xb64dfcf1) [/usr/lib/libcapi-appfw-application.so.0] + 0x1cf1
10: (0xb6efbec9) [/usr/lib/libappcore-efl.so.1] + 0x1ec9
11: (0xb6efc129) [/usr/lib/libappcore-efl.so.1] + 0x2129
12: (0xb6b42c6b) [/usr/lib/libecore.so.1] + 0x7c6b
13: (0xb6b46283) [/usr/lib/libecore.so.1] + 0xb283
14: ecore_main_loop_begin + 0x30 (0xb6b46691) [/usr/lib/libecore.so.1] + 0xb691
15: appcore_efl_main + 0x17e (0xb6efc387) [/usr/lib/libappcore-efl.so.1] + 0x2387
16: ui_app_main + 0xb0 (0xb64e0499) [/usr/lib/libcapi-appfw-application.so.0] + 0x2499
17: app_run + 0x4e (0xb4d43c27) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x4c27
18: main + 0x26 (0xb4d43f5b) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x4f5b
19: _main_view_resume_cb + 0x32 (0xb6f3cdc7) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x2dc7
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
ixed Icon : wifi 33 0 25 36"
08-07 21:15:22.550+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-07 21:15:22.550+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-07 21:15:22.550+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 342 651 5 28 25"
08-07 21:15:22.550+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 343 679 5 28 25"
08-07 21:15:22.550+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
08-07 21:15:22.580+0530 E/Tizen::Locations( 1120): (630) > [E_INVALID_DATA] Location not available.
08-07 21:15:22.850+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:23.150+0530 I/Tizen::System( 1053): (280) > The screen has been turned on.
08-07 21:15:23.150+0530 I/Tizen::Io( 1053): (729) > Entry not found
08-07 21:15:23.150+0530 W/CAM_APP ( 1134): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
08-07 21:15:23.160+0530 I/Tizen::System( 1053): (157) > change brightness system value.
08-07 21:15:23.160+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:23.160+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:23.160+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:23.160+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:23.160+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:23.160+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:23.160+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:23.160+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:23.160+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:23.160+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:23.160+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:23.170+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:23.170+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:23.170+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:23.170+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:23.170+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:23.170+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:23.170+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:23.170+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:23.170+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:23.170+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:23.220+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:23.330+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:23.350+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:23.370+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] gps 0!"
08-07 21:15:23.370+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(726) > "Pack to SYSTEM list : gps"
08-07 21:15:23.370+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-07 21:15:23.370+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-07 21:15:23.380+0530 E/CAPI_LOCATION_MANAGER(  939): location_product.c: _location_manager_gps_state_cb(102) > _location_manager_gps_state_cb
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationVirtual) step(-21) failed(2 / No such file or directory)
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationVirtual : read buf error(-21). break
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationVirtual error
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationTest) step(-21) failed(2 / No such file or directory)
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationTest : read buf error(-21). break
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationTest error
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationVirtual) step(-21) failed(2 / No such file or directory)
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationVirtual : read buf error(-21). break
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationVirtual error
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationVirtual) step(-21) failed(2 / No such file or directory)
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationVirtual : read buf error(-21). break
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationVirtual error
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/QoP/DynamicAcc) step(-21) failed(2 / No such file or directory)
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/QoP/DynamicAcc : read buf error(-21). break
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/QoP/DynamicAcc error
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/QoP/Timeout) step(-21) failed(2 / No such file or directory)
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/QoP/Timeout : read buf error(-21). break
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/QoP/Timeout error
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/QoP/Accuracy) step(-21) failed(2 / No such file or directory)
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/QoP/Accuracy : read buf error(-21). break
08-07 21:15:23.380+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/QoP/Accuracy error
08-07 21:15:23.400+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-07 21:15:23.400+0530 I/indicator(  508): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
08-07 21:15:23.400+0530 I/EFL-ASSIST(  508): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 1c4fbd0 (elm_image), color code: AO004, color [255, 255, 255, 255]
08-07 21:15:23.400+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : gps 418 0 28 36"
08-07 21:15:23.400+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-07 21:15:23.400+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 342 331 5 28 25"
08-07 21:15:23.400+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 343 359 5 28 25"
08-07 21:15:23.400+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
08-07 21:15:23.400+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] gps 1!"
08-07 21:15:23.400+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(726) > "Pack to SYSTEM list : gps"
08-07 21:15:23.400+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-07 21:15:23.400+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-07 21:15:23.400+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-07 21:15:23.400+0530 I/indicator(  508): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
08-07 21:15:23.400+0530 I/EFL-ASSIST(  508): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 1c4e310 (elm_image), color code: AO004, color [255, 255, 255, 255]
08-07 21:15:23.400+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : gps 738 0 28 36"
08-07 21:15:23.410+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-07 21:15:23.410+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 342 651 5 28 25"
08-07 21:15:23.410+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 343 679 5 28 25"
08-07 21:15:23.410+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
08-07 21:15:23.410+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:23.440+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:23.490+0530 E/VCONF   (  939): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
08-07 21:15:23.490+0530 E/VCONF   (  939): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
08-07 21:15:23.490+0530 E/VCONF   (  939): vconf.c: vconf_get_int(2379) > vconf_get_int(939) : file/private/wifi/always_allow_scanning error
08-07 21:15:23.490+0530 E/VCONF   (  939): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
08-07 21:15:23.490+0530 E/VCONF   (  939): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
08-07 21:15:23.490+0530 E/VCONF   (  939): vconf.c: vconf_get_int(2379) > vconf_get_int(939) : file/private/wifi/always_allow_scanning error
08-07 21:15:23.510+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-07 21:15:23.520+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-07 21:15:23.530+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-07 21:15:23.530+0530 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80001:VIEW_GESTURED
08-07 21:15:23.530+0530 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:80001 event_info:0
08-07 21:15:23.530+0530 W/LOCKSCREEN(  576): daemon.c: _lcd_timeout_timer_unset(622) > [_lcd_timeout_timer_unset:622:W] lcd off timer unset
08-07 21:15:23.530+0530 W/LOCKSCREEN(  576): view-mgr.c: _event_route(108) > [_event_route:108:W] event:80001 event_info:0
08-07 21:15:23.530+0530 W/LOCKSCREEN(  576): view-mgr.c: _state_transit(45) > [_state_transit:45:W] state transit:2
08-07 21:15:23.530+0530 W/LOCKSCREEN(  576): view-mgr.c: _state_transit(48) > [_state_transit:48:W] already in same state:2
08-07 21:15:23.540+0530 E/Tizen::Base::Runtime( 1120): (159) > [E_INVALID_STATE] Timer is already started.
08-07 21:15:23.540+0530 E/Tizen::Base::Runtime( 1120): (70) > [E_INVALID_STATE] Failed to start a timer.
08-07 21:15:23.660+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:23.860+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:23.910+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:24.160+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:24.360+0530 I/Tizen::Net::Wifi( 1082): (928) > The background scan result updated.
08-07 21:15:24.360+0530 I/Tizen::Net::Wifi( 1082): (934) > Fire event [WIFI_EVENT_SCAN_COMPLETED]
08-07 21:15:24.370+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:24.420+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:24.440+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-07 21:15:24.440+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-07 21:15:24.620+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:24.670+0530 E/CAPI_LOCATION_MANAGER(  939): location_product.c: _location_manager_gps_state_cb(102) > _location_manager_gps_state_cb
08-07 21:15:24.670+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-07 21:15:24.670+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:24.670+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-07 21:15:24.670+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-07 21:15:24.670+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 390 0 56 36"
08-07 21:15:24.670+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 342 303 5 28 25"
08-07 21:15:24.670+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 343 331 5 28 25"
08-07 21:15:24.670+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
08-07 21:15:24.670+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-07 21:15:24.670+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-07 21:15:24.670+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-07 21:15:24.670+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 710 0 56 36"
08-07 21:15:24.670+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 342 623 5 28 25"
08-07 21:15:24.670+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 343 651 5 28 25"
08-07 21:15:24.670+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
08-07 21:15:24.680+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:24.680+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:24.680+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:24.680+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:24.680+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:24.680+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:24.680+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:24.680+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:24.680+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:24.680+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:24.780+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-07 21:15:24.780+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-07 21:15:24.860+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:24.920+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:25.000+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-07 21:15:25.000+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-07 21:15:25.170+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:25.210+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-07 21:15:25.210+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-07 21:15:25.360+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:25.420+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:25.560+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-07 21:15:25.560+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-07 21:15:25.670+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:25.710+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:25.860+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:25.920+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:26.180+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:26.360+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:26.430+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:26.680+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:26.750+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:26.750+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:26.750+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:26.750+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:26.750+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:26.750+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:26.750+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:26.750+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:26.750+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:26.750+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:26.750+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:26.860+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:26.930+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:27.050+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-07 21:15:27.050+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-07 21:15:27.180+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:27.370+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:27.430+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:27.680+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:27.790+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:27.860+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:27.940+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:28.100+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-07 21:15:28.100+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-07 21:15:28.190+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:28.310+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-07 21:15:28.310+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-07 21:15:28.370+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:28.440+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:28.460+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-07 21:15:28.460+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-07 21:15:28.610+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-07 21:15:28.610+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-07 21:15:28.700+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:28.870+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:28.940+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:28.940+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:28.940+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:28.940+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:28.940+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:28.940+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:28.950+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:28.950+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:28.950+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:28.950+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:28.950+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:28.960+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:29.100+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-07 21:15:29.100+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-07 21:15:29.210+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:29.360+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-07 21:15:29.360+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-07 21:15:29.370+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:29.460+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:29.630+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-07 21:15:29.630+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-07 21:15:29.710+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:29.870+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:29.960+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:29.990+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:30.030+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-07 21:15:30.030+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-07 21:15:30.040+0530 E/LOCKSCREEN(  576): password-verification.c: __password_verification_check_phone_password(254) > [__password_verification_check_phone_password:254:E] correct password!
08-07 21:15:30.040+0530 W/LOCKSCREEN(  576): simple-password.c: _pwd_verify_result_cb(522) > [_pwd_verify_result_cb:522:W] event:3
08-07 21:15:30.050+0530 W/LOCKSCREEN(  576): daemon.c: lockd_event_delay(917) > [lockd_event_delay:917:W] dealyed event:2:UNLOCK wait for:0.500000
08-07 21:15:30.210+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:30.370+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:30.470+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:30.560+0530 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:2 event_info:0
08-07 21:15:30.560+0530 W/LOCKSCREEN(  576): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:6
08-07 21:15:30.560+0530 W/LOCKSCREEN(  576): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => HIDE
08-07 21:15:30.570+0530 E/WALLPAPER_SERVICE_COMMON(  576): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
08-07 21:15:30.660+0530 W/LOCKSCREEN(  576): util-daemon.c: _ckmc_unlock_timer_cb(196) > [_ckmc_unlock_timer_cb:196:W] key manager unlock:0
08-07 21:15:30.670+0530 W/PROCESSMGR(  343): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=9302
08-07 21:15:30.670+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-07 21:15:30.680+0530 I/CAPI_APPFW_APPLICATION( 9302): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
08-07 21:15:30.690+0530 I/indicator(  508): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.watchdog, pid = 9302"
08-07 21:15:30.710+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-07 21:15:30.730+0530 I/Tizen::System( 1053): (259) > Active app [org.tizen.], current [com.samsun] 
08-07 21:15:30.730+0530 I/Tizen::Io( 1053): (729) > Entry not found
08-07 21:15:30.750+0530 W/LOCKSCREEN(  576): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x2000008] is now visible(1)
08-07 21:15:30.750+0530 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10002:WIN_BECOME_INVISIBLE
08-07 21:15:30.750+0530 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:10002 event_info:0
08-07 21:15:30.750+0530 I/CAPI_APPFW_APPLICATION(  576): app_main.c: app_appcore_pause(202) > app_appcore_pause
08-07 21:15:30.750+0530 E/LOCKSCREEN(  576): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
08-07 21:15:30.750+0530 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20002:APP_PAUSE
08-07 21:15:30.750+0530 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:20002 event_info:0
08-07 21:15:30.760+0530 I/Tizen::System( 1120): (101) > Active App is org.tizen.watchdog. GetApp id ACL111OMWW.AclService
08-07 21:15:30.760+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-07 21:15:30.760+0530 D/PowerManagerService( 1575): calling setSysScreenBrightness(brightness = 255)
08-07 21:15:30.760+0530 I/power   ( 1575): *** set_screen_state 1
08-07 21:15:30.760+0530 I/PowerManagerService-JNI( 1575): sending ACL screen state 'L'
08-07 21:15:30.770+0530 I/Tizen::System( 1053): (157) > change brightness system value.
08-07 21:15:30.770+0530 D/SensorService( 1575): actuateSensor
08-07 21:15:30.770+0530 D/AclServiceManager( 1575): -----*******------------ enableSensor  : 0
08-07 21:15:30.770+0530 D/SensorService( 1575): setSensorDelay
08-07 21:15:30.770+0530 D/AclServiceManager( 1575): -----*******------------ setSensorDelay : 0 to 200
08-07 21:15:30.770+0530 D/SensorService( 1575): setSensorDelay
08-07 21:15:30.770+0530 D/AclServiceManager( 1575): -----*******------------ setSensorDelay : 0 to 200
08-07 21:15:30.780+0530 D/ACL     ( 1575): ************ onActivityResumed()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
08-07 21:15:30.780+0530 D/ACL     ( 1575): >>>>>>>>  send : cmd=CMD_SHOW_DESKTOP  pkg= null  taskid=0 status=-1
08-07 21:15:30.780+0530 I/AclService( 1120): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
08-07 21:15:30.780+0530 I/PowerManagerService-JNI( 1575): sending ACL screen state 'F'
08-07 21:15:30.780+0530 I/AclService( 1120): void SocketThread::send_flinger(int, const char*, int, int)(396) > handle_app_manager_msg: cmd=7(CMD_SHOW_DESKTOP) taskid=0  pkg='' status='-1' app=''
08-07 21:15:30.780+0530 I/AclService( 1120): void minimize()(280) > Minimizing all vfb clients
08-07 21:15:30.780+0530 I/AclService( 1120): void minimize()(283) > minimizing {pkg=surfaceflinger fd=98}
08-07 21:15:30.780+0530 I/Tizen::System( 1120): (461) > change cpu power policy: keepAwake(true)
08-07 21:15:30.790+0530 I/Tizen::System( 1120): (461) > change cpu power policy: keepAwake(false)
08-07 21:15:30.790+0530 E/Tizen::Io( 1120): (133) > [E_INVALID_ARG] The application id is empty.
08-07 21:15:30.790+0530 I/Tizen::Base::Runtime( 1120): (251) > The timer is not started.
08-07 21:15:30.870+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:30.900+0530 W/LOCKSCREEN(  576): view-mgr.c: _event_route(108) > [_event_route:108:W] event:2 event_info:0
08-07 21:15:30.900+0530 E/LOCKSCREEN(  576): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
08-07 21:15:30.900+0530 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80000:VIEW_IDLE
08-07 21:15:30.900+0530 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:80000 event_info:0
08-07 21:15:30.910+0530 E/LOCKSCREEN(  576): background-view.c: background_image_next_set(179) > [background_image_next_set:179:E] fopen wallpaper txt file failed.
08-07 21:15:31.030+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:31.030+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:31.030+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:31.030+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:31.030+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:31.030+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:31.030+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:31.030+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:31.030+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:31.030+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:31.030+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:31.370+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:31.870+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:32.060+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:32.370+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:32.690+0530 I/MALI    ( 9302): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb8e61340] swap changed from async to sync
08-07 21:15:32.870+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:33.100+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:33.100+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:33.100+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:33.100+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:33.100+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:33.100+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:33.100+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:33.100+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:33.100+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:33.100+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:33.100+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:33.370+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:33.870+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:34.140+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:34.370+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:34.880+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:35.170+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:35.170+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:35.170+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:35.170+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:35.170+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:35.170+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:35.170+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:35.170+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:35.170+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:35.170+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:35.170+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:35.370+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:35.750+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:35.870+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:35.870+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:35.900+0530 E/CAPI_LOCATION_MANAGER(  939): location_product.c: _location_manager_gps_state_cb(102) > _location_manager_gps_state_cb
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationVirtual) step(-21) failed(2 / No such file or directory)
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationVirtual : read buf error(-21). break
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationVirtual error
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationTest) step(-21) failed(2 / No such file or directory)
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationTest : read buf error(-21). break
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationTest error
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationVirtual) step(-21) failed(2 / No such file or directory)
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationVirtual : read buf error(-21). break
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationVirtual error
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationVirtual) step(-21) failed(2 / No such file or directory)
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationVirtual : read buf error(-21). break
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationVirtual error
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/QoP/DynamicAcc) step(-21) failed(2 / No such file or directory)
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/QoP/DynamicAcc : read buf error(-21). break
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/QoP/DynamicAcc error
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/QoP/Timeout) step(-21) failed(2 / No such file or directory)
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/QoP/Timeout : read buf error(-21). break
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/QoP/Timeout error
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/QoP/Accuracy) step(-21) failed(2 / No such file or directory)
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/QoP/Accuracy : read buf error(-21). break
08-07 21:15:35.910+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/QoP/Accuracy error
08-07 21:15:35.910+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] gps 0!"
08-07 21:15:35.910+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(726) > "Pack to SYSTEM list : gps"
08-07 21:15:35.910+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-07 21:15:35.910+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-07 21:15:35.910+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-07 21:15:35.910+0530 I/indicator(  508): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
08-07 21:15:35.910+0530 I/EFL-ASSIST(  508): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 1c4def0 (elm_image), color code: AO004, color [255, 255, 255, 255]
08-07 21:15:35.920+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : gps 418 0 28 36"
08-07 21:15:35.920+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-07 21:15:35.920+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 342 331 5 28 25"
08-07 21:15:35.920+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 343 359 5 28 25"
08-07 21:15:35.920+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
08-07 21:15:35.920+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] gps 1!"
08-07 21:15:35.920+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(726) > "Pack to SYSTEM list : gps"
08-07 21:15:35.920+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-07 21:15:35.920+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-07 21:15:35.920+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-07 21:15:35.930+0530 I/indicator(  508): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
08-07 21:15:35.930+0530 I/EFL-ASSIST(  508): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 1c4fd30 (elm_image), color code: AO004, color [255, 255, 255, 255]
08-07 21:15:35.930+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : gps 738 0 28 36"
08-07 21:15:35.930+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-07 21:15:35.930+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 342 651 5 28 25"
08-07 21:15:35.930+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 343 679 5 28 25"
08-07 21:15:35.930+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
08-07 21:15:36.230+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:36.250+0530 E/TIZEN_N_CAMERA( 9302): camera.c: camera_stop_face_detection(1250) > NOT SUPPORTED
08-07 21:15:36.350+0530 W/TIZEN_N_CAMERA( 9302): camera.c: camera_destroy(844) > camera handle 0xb8ffd7d0
08-07 21:15:36.350+0530 I/TIZEN_N_CAMERA( 9302): camera.c: _camera_remove_cb_message(92) > start
08-07 21:15:36.350+0530 W/TIZEN_N_CAMERA( 9302): camera.c: _camera_remove_cb_message(118) > There is no remained callback
08-07 21:15:36.350+0530 I/TIZEN_N_CAMERA( 9302): camera.c: _camera_remove_cb_message(123) > done
08-07 21:15:36.370+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:36.770+0530 D/PowerManagerService( 1575): calling setSysScreenBrightness(brightness = 255)
08-07 21:15:36.770+0530 I/AclService( 1120): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
08-07 21:15:36.870+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:37.150+0530 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-07 21:15:37.150+0530 W/AUL_AMD (  455): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-07 21:15:37.230+0530 W/PROCESSMGR(  343): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=604
08-07 21:15:37.240+0530 I/MALI    ( 9302): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb8e61340] swap changed from sync to async
08-07 21:15:37.250+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-07 21:15:37.300+0530 I/Tizen::System( 1053): (259) > Active app [com.samsun], current [org.tizen.] 
08-07 21:15:37.300+0530 I/Tizen::Io( 1053): (729) > Entry not found
08-07 21:15:37.310+0530 I/Tizen::System( 1053): (157) > change brightness system value.
08-07 21:15:37.310+0530 I/indicator(  508): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 604"
08-07 21:15:37.310+0530 I/CAPI_APPFW_APPLICATION(  604): app_main.c: app_appcore_resume(223) > app_appcore_resume
08-07 21:15:37.310+0530 E/cluster-home(  604): homescreen-main.cpp: app_resume(422) >  app resume
08-07 21:15:37.320+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 0
08-07 21:15:37.340+0530 I/AUL     (  455): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/data-provider-master, ret : 0
08-07 21:15:37.350+0530 I/AUL     (  455): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/data-provider-master, ret : 0
08-07 21:15:37.350+0530 E/AUL_AMD (  455): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
08-07 21:15:37.400+0530 I/CAPI_APPFW_APPLICATION( 9302): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
08-07 21:15:37.490+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:37.600+0530 I/CAPI_APPFW_APPLICATION(12655): app_main.c: ui_app_main(699) > app_efl_main
08-07 21:15:37.610+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:15:37.670+0530 I/UXT     (12655): uxt_object_manager.cpp: on_initialized(287) > Initialized.
08-07 21:15:37.680+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-07 21:15:37.690+0530 I/Tizen::System( 1120): (101) > Active App is com.samsung.homescreen. GetApp id ACL111OMWW.AclService
08-07 21:15:37.690+0530 E/RESOURCED(  837): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 312
08-07 21:15:37.710+0530 I/Tizen::App(  999): (499) > LaunchedApp(com.samsung.data-provider-slave)
08-07 21:15:37.710+0530 I/Tizen::App(  999): (733) > Finished invoking application event listener for com.samsung.data-provider-slave, 12655.
08-07 21:15:37.710+0530 I/Tizen::App( 1053): (733) > Finished invoking application event listener for com.samsung.data-provider-slave, 12655.
08-07 21:15:37.710+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:37.710+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:37.710+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:37.710+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:37.720+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:37.720+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:15:37.720+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:15:37.720+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:15:37.720+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:15:37.720+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:15:37.800+0530 I/CAPI_APPFW_APPLICATION(12655): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
08-07 21:15:37.850+0530 I/EFL-ASSIST(12655): efl_assist_theme_font.c: ea_theme_font_table_new(393) > font table (b8e2dae8) from (/usr/share/themes/FontInfoTable.xml) is created
08-07 21:15:37.850+0530 E/TIZEN_N_SYSTEM_SETTINGS(12655): system_settings.c: system_settings_set_changed_cb(541) > b4cfb1fd
08-07 21:15:37.850+0530 E/TIZEN_N_SYSTEM_SETTINGS(12655): system_settings_vconf.c: system_setting_vconf_set_changed_cb(263) > [system_setting_vconf_set_changed_cb] vconf_notify_key_changed registered : db/setting/accessibility/font_size --- callback ptr : b4cf9dfd
08-07 21:15:37.850+0530 E/EFL     (12655): evas_main<12655> evas_font_dir.c:1515 evas_font_reinit() ENTER:: evas_font_reinit
08-07 21:15:37.880+0530 E/EFL     (12655): evas_main<12655> evas_font_dir.c:1526 evas_font_reinit() DONE:: evas_font_reinit
08-07 21:15:37.910+0530 I/EFL-ASSIST(12655): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b8e3e370) from (/opt/usr/share/data-provider-slave/theme/color/com.samsung.data-provider-slave_ChangeableColorInfo.xml) is created
08-07 21:15:37.920+0530 E/EFL-ASSIST(12655): efl_assist_theme_color.cpp: ea_theme_colors_set(868) > cannot get color table data
08-07 21:15:37.930+0530 I/CAPI_APPFW_APPLICATION(12655): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
08-07 21:15:37.950+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:37.980+0530 I/APP_CORE(12655): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
08-07 21:15:37.980+0530 I/APP_CORE(12655): appcore-efl.c: __do_app(511) > [APP 12655] Initial Launching, call the resume_cb
08-07 21:15:37.980+0530 I/CAPI_APPFW_APPLICATION(12655): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
08-07 21:15:38.040+0530 I/RESOURCED(  837): logging.c: broadcast_logging_data_updated_signal(714) > [broadcast_logging_data_updated_signal,714] broadcast logging_data updated signal!
08-07 21:15:38.480+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:15:38.490+0530 W/CRASH_MANAGER(12663): worker.c: worker_job(1236) > 1109302776174143896233
