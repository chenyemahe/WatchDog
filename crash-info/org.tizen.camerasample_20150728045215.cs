S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: camerasample
PID: 25720
Date: 2015-07-28 04:52:15+0530
Executable File Path: /opt/usr/apps/org.tizen.camerasample/bin/camerasample
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 25720, uid 5000)

Register Information
r0   = 0x00000013, r1   = 0xb4d84b48
r2   = 0x006d6f63, r3   = 0x00000000
r4   = 0xb4d84b34, r5   = 0x00000046
r6   = 0x00000000, r7   = 0xbeffc870
r8   = 0x00000041, r9   = 0x00000001
r10  = 0x00000013, fp   = 0x00000000
ip   = 0xb6c80d60, sp   = 0xbeffc838
lr   = 0xb4f2a2f1, pc   = 0xb4f2a2fc
cpsr = 0x60000030

Memory Information
MemTotal:   730748 KB
MemFree:     33044 KB
Buffers:     24328 KB
Cached:     241308 KB
VmPeak:     268612 KB
VmSize:     268608 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22828 KB
VmRSS:       22824 KB
VmData:     197328 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       30940 KB
VmPTE:         116 KB
VmSwap:          0 KB

Threads Information
Threads: 25
PID = 25720 TID = 25720
25720 25725 25726 25731 25732 25733 25735 25736 25737 25738 25739 25741 25742 25743 25744 25745 25746 25747 25748 25749 25751 25752 25758 27653 27655 

Maps Information
a6bd3000 a73d2000 rw-p [stack:27655]
a83bd000 a8bbc000 rw-p [stack:27653]
a9201000 a9a00000 rw-p [stack:25752]
a9a01000 aa200000 rw-p [stack:25751]
aa201000 aaa00000 rw-p [stack:25758]
aaa01000 ab200000 rw-p [stack:25749]
ab201000 aba00000 rw-p [stack:25748]
aba01000 ac200000 rw-p [stack:25747]
ac201000 aca00000 rw-p [stack:25746]
aca01000 ad200000 rw-p [stack:25745]
ad201000 ada00000 rw-p [stack:25744]
ada01000 ae200000 rw-p [stack:25743]
ae201000 aea00000 rw-p [stack:25742]
aea01000 af200000 rw-p [stack:25741]
af201000 afa00000 rw-p [stack:25739]
afa01000 b0200000 rw-p [stack:25738]
b0366000 b0b65000 rw-p [stack:25737]
b0b66000 b1365000 rw-p [stack:25736]
b1366000 b1b65000 rw-p [stack:25735]
b1b65000 b1b73000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b1b91000 b1bc6000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
b1bcf000 b1bd0000 r-xp /usr/lib/libbincfg.so.1.1
b1bd8000 b1c1e000 r-xp /usr/lib/libcamera-interface-sprd-sc7727.so.0.0.0
b1c2e000 b1c76000 r-xp /usr/lib/libcamerahal.so.0.0.0
b1c84000 b1c8e000 r-xp /usr/lib/gstreamer-0.10/libgstevasimagesink.so
b1c96000 b1cac000 r-xp /usr/lib/gstreamer-0.10/libgstcamerasrc.so
b1cb5000 b24b4000 rw-p [stack:25733]
b24d1000 b2cd0000 rw-p [stack:25732]
b2cd1000 b34d0000 rw-p [stack:25731]
b34d0000 b34d1000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b34e7000 b34e8000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b34f0000 b3507000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b36ae000 b36b2000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b36bc000 b3ebb000 rw-p [stack:25725]
b3ebb000 b4002000 r-xp /usr/lib/driver/libMali.so
b400f000 b40d9000 r-xp /usr/lib/libCOREGL.so.4.0
b40ea000 b40ed000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b40f5000 b40f8000 r-xp /usr/lib/libEGL.so.1.4
b4100000 b410e000 r-xp /usr/lib/libGLESv2.so.2.0
b4117000 b4167000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b43ad000 b43c1000 r-xp /usr/lib/libnetwork.so.0.0.0
b43c9000 b43d2000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.26
b43da000 b43dc000 r-xp /usr/lib/libdevice_info.so.0.0.2
b43e4000 b43e6000 r-xp /usr/lib/libcryptsvc.so.0.0.2
b43ee000 b440a000 r-xp /usr/lib/libdrm-service-core-tizen.so.0.3.9
b4421000 b4428000 r-xp /usr/lib/libminizip.so.1.0.0
b4430000 b4432000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b443a000 b4441000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b444a000 b4466000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b446f000 b4475000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b447d000 b448e000 r-xp /lib/libnsl-2.13.so
b4499000 b44a1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.55
b44a9000 b44aa000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b44b2000 b44bb000 r-xp /usr/lib/libcom-core.so.0.0.1
b44c3000 b44de000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b44e6000 b44eb000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b44f3000 b44fb000 r-xp /usr/lib/libpims-ipc.so.0.1.18
b4503000 b4564000 r-xp /usr/lib/libasound.so.2.0.0
b456e000 b4572000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b457a000 b457d000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b4586000 b4588000 r-xp /usr/lib/libemail-network.so.1.1.0
b4590000 b4594000 r-xp /usr/lib/libstorage.so.0.1
b459c000 b45d2000 r-xp /usr/lib/libgmime-2.6.so.0.600.15
b45ed000 b472c000 r-xp /usr/lib/libicui18n.so.51.1
b473c000 b4740000 r-xp /usr/lib/libbadge.so.0.0.1
b4748000 b474f000 r-xp /usr/lib/libfeedback.so.0.1.4
b4763000 b4770000 r-xp /usr/lib/libnotification.so.0.1.0
b4778000 b4784000 r-xp /usr/lib/libalarm.so.0.0.0
b478d000 b47a0000 r-xp /usr/lib/libaccounts-svc.so.0.2.97
b47a8000 b47ec000 r-xp /usr/lib/libcontacts-service2.so.0.12.54
b47f7000 b48a1000 r-xp /usr/lib/libuw-imap-toolkit.so.0.0.0
b48ae000 b48b2000 r-xp /usr/lib/libss-client.so.1.0.0
b48ba000 b48c3000 r-xp /usr/lib/libmdm-common.so.1.0.45
b48cb000 b4913000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4914000 b491a000 r-xp /usr/lib/libjson.so.0.1.0
b4922000 b492a000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b4939000 b493b000 r-xp /usr/lib/libiniparser.so.0
b4945000 b495b000 r-xp /usr/lib/lib_SamsungRec_TizenV04009.so
b4989000 b498c000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b4994000 b49aa000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b49b2000 b49b6000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b49bf000 b4a02000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b4a0a000 b4a17000 r-xp /usr/lib/libemail-common-use.so.1.1.0
b4a1f000 b4a8b000 r-xp /usr/lib/libemail-core.so.1.1.0
b4a9c000 b4ad8000 r-xp /usr/lib/libemail-storage.so.1.1.0
b4ae1000 b4aea000 r-xp /usr/lib/libemail-ipc.so.1.1.0
b4af2000 b4af4000 r-xp /usr/lib/libdri2.so.0.0.0
b4afc000 b4b03000 r-xp /usr/lib/libdrm.so.2.4.0
b4b0c000 b4b10000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4b19000 b4b2c000 r-xp /usr/lib/libmdm.so.1.0.88
b4b34000 b4b3a000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b4b43000 b4b4d000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b4b59000 b4b61000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4b69000 b4b6b000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
b4b73000 b4baa000 r-xp /usr/lib/libpulse.so.0.16.2
b4bb3000 b4bb8000 r-xp /usr/lib/libmmfsession.so.0.0.0
b4bc0000 b4bd5000 r-xp /usr/lib/libmmfsound.so.0.1.0
b4bdd000 b4be0000 r-xp /usr/lib/libmm_ta.so.0.0.0
b4be8000 b4bf1000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b4bf9000 b4c06000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b4c0f000 b4c1f000 r-xp /usr/lib/libemail-api.so.1.1.0
b4c27000 b4c2e000 r-xp /usr/lib/libtbm.so.1.0.0
b4c36000 b4cd1000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b4cdd000 b4ce2000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4cea000 b4d3b000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b4d49000 b4d4b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4d53000 b4d63000 r-xp /usr/lib/libcapi-media-camera.so.0.1.71
b4d6d000 b4d77000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4d80000 b4d85000 r-xp /opt/usr/apps/org.tizen.camerasample/bin/camerasample
b4d90000 b4d9a000 r-xp /lib/libnss_files-2.13.so
b4da3000 b4db5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4dbd000 b4dd3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4ddb000 b4ea9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4ec0000 b4ee4000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4eed000 b4ef3000 r-xp /usr/lib/libappsvc.so.0.1.0
b4efb000 b4f09000 r-xp /usr/lib/libail.so.0.1.0
b4f11000 b4f13000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b4f1c000 b4f21000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b4f29000 b4f2b000 r-xp /usr/lib/libcapi-messaging-email.so.0.1.24
b4f34000 b4f35000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4f3e000 b4f42000 r-xp /usr/lib/libogg.so.0.7.1
b4f4a000 b4f6c000 r-xp /usr/lib/libvorbis.so.0.4.3
b4f74000 b5058000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b506c000 b509d000 r-xp /usr/lib/libFLAC.so.8.2.0
b5a37000 b5acb000 r-xp /usr/lib/libstdc++.so.6.0.16
b5ade000 b5ae0000 r-xp /usr/lib/libXau.so.6.0.0
b5ae8000 b5af2000 r-xp /usr/lib/libspdy.so.0.0.0
b5afb000 b5b47000 r-xp /usr/lib/libssl.so.1.0.0
b5b54000 b5b82000 r-xp /usr/lib/libidn.so.11.5.44
b5b8a000 b5b94000 r-xp /usr/lib/libcares.so.2.1.0
b5b9c000 b5bbd000 r-xp /usr/lib/libexif.so.12.3.3
b5bd0000 b5c15000 r-xp /usr/lib/libsndfile.so.1.0.25
b5c23000 b5c39000 r-xp /lib/libexpat.so.1.5.2
b5c42000 b5d27000 r-xp /usr/lib/libicuuc.so.51.1
b5d3c000 b5d70000 r-xp /usr/lib/libicule.so.51.1
b5d79000 b5d8c000 r-xp /usr/lib/libxcb.so.1.1.0
b5d94000 b5dd1000 r-xp /usr/lib/libcurl.so.4.3.0
b5dda000 b5de3000 r-xp /usr/lib/libethumb.so.1.7.99
b5dec000 b5dee000 r-xp /usr/lib/libctxdata.so.0.0.0
b5df6000 b5e03000 r-xp /usr/lib/libremix.so.0.0.0
b5e0b000 b5e0c000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e14000 b5e2b000 r-xp /usr/lib/liblua-5.1.so
b5e34000 b5e3b000 r-xp /usr/lib/libembryo.so.1.7.99
b5e43000 b5e66000 r-xp /usr/lib/libjpeg.so.8.0.2
b5e7e000 b5ed4000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5ee1000 b5f34000 r-xp /usr/lib/libfreetype.so.6.8.1
b5f3f000 b5f67000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5f68000 b5fae000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5fb7000 b5fca000 r-xp /usr/lib/libfribidi.so.0.3.1
b5fd2000 b5fd5000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5fdd000 b5fe1000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5fe9000 b5fee000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5ff7000 b6001000 r-xp /usr/lib/libXext.so.6.4.0
b6009000 b60ea000 r-xp /usr/lib/libX11.so.6.3.0
b60f5000 b60f8000 r-xp /usr/lib/libXtst.so.6.1.0
b6100000 b6106000 r-xp /usr/lib/libXrender.so.1.3.0
b610e000 b6113000 r-xp /usr/lib/libXrandr.so.2.2.0
b611b000 b611c000 r-xp /usr/lib/libXinerama.so.1.0.0
b6125000 b612d000 r-xp /usr/lib/libXi.so.6.1.0
b612e000 b6131000 r-xp /usr/lib/libXfixes.so.3.1.0
b6139000 b613b000 r-xp /usr/lib/libXgesture.so.7.0.0
b6143000 b6145000 r-xp /usr/lib/libXcomposite.so.1.0.0
b614d000 b614e000 r-xp /usr/lib/libXdamage.so.1.1.0
b6157000 b615d000 r-xp /usr/lib/libXcursor.so.1.0.2
b6166000 b617f000 r-xp /usr/lib/libecore_con.so.1.7.99
b6189000 b618f000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6197000 b619f000 r-xp /usr/lib/libethumb_client.so.1.7.99
b61a7000 b61b0000 r-xp /usr/lib/libedbus.so.1.7.99
b61b8000 b6215000 r-xp /usr/lib/libedje.so.1.7.99
b621e000 b622f000 r-xp /usr/lib/libecore_input.so.1.7.99
b6237000 b623c000 r-xp /usr/lib/libecore_file.so.1.7.99
b6244000 b625d000 r-xp /usr/lib/libeet.so.1.7.99
b626e000 b6272000 r-xp /usr/lib/libappcore-common.so.1.1
b627a000 b6341000 r-xp /usr/lib/libevas.so.1.7.99
b6366000 b6387000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6390000 b63bf000 r-xp /usr/lib/libecore_x.so.1.7.99
b63c9000 b6500000 r-xp /usr/lib/libelementary.so.1.7.99
b6516000 b6517000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b651f000 b6523000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b652e000 b6531000 r-xp /lib/libgpg-error.so.0.5.0
b6539000 b6591000 r-xp /usr/lib/libgcrypt.so.11.5.3
b659b000 b65c7000 r-xp /usr/lib/libsystemd.so.0.0.1
b65d0000 b65d2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b65db000 b66a6000 r-xp /usr/lib/libxml2.so.2.7.8
b66b4000 b66c4000 r-xp /lib/libresolv-2.13.so
b66c8000 b66de000 r-xp /lib/libz.so.1.2.5
b66e6000 b66e8000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b66f0000 b66f5000 r-xp /usr/lib/libffi.so.5.0.10
b66fe000 b66ff000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6707000 b670a000 r-xp /lib/libattr.so.1.1.0
b6712000 b6715000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b671d000 b6724000 r-xp /usr/lib/libvconf.so.0.2.45
b672d000 b68d5000 r-xp /usr/lib/libcrypto.so.1.0.0
b68f6000 b690c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6914000 b697d000 r-xp /lib/libm-2.13.so
b6986000 b69c6000 r-xp /usr/lib/libeina.so.1.7.99
b69cf000 b6a03000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6a0c000 b6ae0000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6aec000 b6af1000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6afa000 b6b00000 r-xp /lib/librt-2.13.so
b6b09000 b6b10000 r-xp /lib/libcrypt-2.13.so
b6b40000 b6b43000 r-xp /lib/libcap.so.2.21
b6b4b000 b6b4d000 r-xp /usr/lib/libiri.so
b6b55000 b6b74000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b7c000 b6b92000 r-xp /usr/lib/libecore.so.1.7.99
b6ba8000 b6bad000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bb6000 b6bcd000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bd6000 b6be1000 r-xp /lib/libunwind.so.8.0.1
b6c0e000 b6d29000 r-xp /lib/libc-2.13.so
b6d37000 b6d3f000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d47000 b6d71000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6d7a000 b6d7d000 r-xp /usr/lib/libbundle.so.0.1.22
b6d85000 b6d87000 r-xp /lib/libdl-2.13.so
b6d90000 b6d93000 r-xp /usr/lib/libsmack.so.1.0.0
b6d9b000 b6e6b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6e6c000 b6ed1000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6edb000 b6eed000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ef5000 b6f09000 r-xp /lib/libpthread-2.13.so
b6f14000 b6f16000 r-xp /usr/lib/libdlog.so.0.0.0
b6f1e000 b6f29000 r-xp /usr/lib/libaul.so.0.1.0
b6f37000 b6f3a000 rw-p [stack:25726]
b6f3b000 b6f3e000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f48000 b6f4c000 r-xp /usr/lib/libsys-assert.so
b6f55000 b6f72000 r-xp /lib/ld-2.13.so
b6f7b000 b6f80000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b8e9d000 b8ee6000 rw-p [heap]
b8ee6000 b9210000 rw-p [heap]
befdd000 beffe000 rw-p [stack]
befdd000 beffe000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25720)
Call Stack Count: 1
 0: email_add_recipient + 0x33 (0xb4f2a2fc) [/usr/lib/libcapi-messaging-email.so.0] + 0x12fc
End of Call Stack

Package Information
Package Name: org.tizen.camerasample
Package ID : org.tizen.camerasample
Version: 1.0.0
Package Type: rpm
App Name: WatchDog
App ID: org.tizen.camerasample
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
namicAcc : read buf error(-21). break
07-28 04:52:06.780+0530 E/VCONF   (  883): vconf.c: vconf_get_int(2379) > vconf_get_int(883) : db/location/gps/QoP/DynamicAcc error
07-28 04:52:06.780+0530 E/VCONF   (  883): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/QoP/Timeout) step(-21) failed(2 / No such file or directory)
07-28 04:52:06.780+0530 E/VCONF   (  883): vconf.c: _vconf_get_key(2111) > db/location/gps/QoP/Timeout : read buf error(-21). break
07-28 04:52:06.780+0530 E/VCONF   (  883): vconf.c: vconf_get_int(2379) > vconf_get_int(883) : db/location/gps/QoP/Timeout error
07-28 04:52:06.780+0530 E/VCONF   (  883): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/QoP/Accuracy) step(-21) failed(2 / No such file or directory)
07-28 04:52:06.780+0530 E/VCONF   (  883): vconf.c: _vconf_get_key(2111) > db/location/gps/QoP/Accuracy : read buf error(-21). break
07-28 04:52:06.780+0530 E/VCONF   (  883): vconf.c: vconf_get_int(2379) > vconf_get_int(883) : db/location/gps/QoP/Accuracy error
07-28 04:52:06.810+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb0b00c58)
07-28 04:52:06.810+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(38) mail_id(38) info(0xb8717be0)
07-28 04:52:06.810+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
07-28 04:52:06.810+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
07-28 04:52:06.810+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 36
07-28 04:52:06.810+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb0b00c58)
07-28 04:52:06.810+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:07.250+0530 E/LOCATION( 1131): location-privacy.c: location_get_privacy(174) > CPPAPP use location
07-28 04:52:07.320+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:07.430+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 5, data3: , data4: 14
07-28 04:52:07.430+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
07-28 04:52:07.430+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10000, data1: 1, data2: 39, data3: 13, data4: 39
07-28 04:52:07.430+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(710) > NOTI_MAIL_ADD
07-28 04:52:07.430+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(717) > mailbox_ugd->mode(1), mailbox_ugd->mailbox_type(1), mailbox_ugd->mailbox_id(13), view_type(0)
07-28 04:52:07.430+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_cb(884) > Ecore_Thread(0xb0b00c58)
07-28 04:52:07.530+0530 W/cluster-view(  609): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2041) >  booster timer is still running on apps-view, Stop boost timer!!!
07-28 04:52:07.750+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10000, data1: 1, data2: 40, data3: 13, data4: 40
07-28 04:52:07.750+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(710) > NOTI_MAIL_ADD
07-28 04:52:07.750+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(717) > mailbox_ugd->mode(1), mailbox_ugd->mailbox_type(1), mailbox_ugd->mailbox_id(13), view_type(0)
07-28 04:52:07.760+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_cb(884) > Ecore_Thread(0xb87d71e0)
07-28 04:52:07.790+0530 I/AclService( 1131): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-28 04:52:07.790+0530 I/Tizen::System( 1043): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-28 04:52:07.820+0530 I/Tizen::System( 1043): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-28 04:52:07.820+0530 I/Tizen::System( 1043): (426) > Result Code is E_SUCCESS.
07-28 04:52:07.820+0530 I/Tizen::System( 1043): (432) > Value is 1.
07-28 04:52:07.820+0530 I/Tizen::System( 1131): (637) > result is 1.
07-28 04:52:07.820+0530 I/AclService( 1131): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001c (28)
07-28 04:52:07.820+0530 I/Tizen::Net::Wifi( 1087): (637) > OnGetWifiConnectionState with clientId : 1131, AppPkgId : ACL111OMWW
07-28 04:52:07.820+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:07.820+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10000, data1: 1, data2: 41, data3: 13, data4: 41
07-28 04:52:07.820+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(710) > NOTI_MAIL_ADD
07-28 04:52:07.820+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(717) > mailbox_ugd->mode(1), mailbox_ugd->mailbox_type(1), mailbox_ugd->mailbox_id(13), view_type(0)
07-28 04:52:07.820+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_cb(884) > Ecore_Thread(0xb895f358)
07-28 04:52:07.880+0530 D/WifiStateTracker( 1409): Tizen getWifiState state = 3
07-28 04:52:07.880+0530 I/AclService( 1131): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-28 04:52:07.880+0530 I/Tizen::System( 1043): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-28 04:52:07.900+0530 I/Tizen::System( 1043): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-28 04:52:07.900+0530 I/Tizen::System( 1043): (426) > Result Code is E_SUCCESS.
07-28 04:52:07.900+0530 I/Tizen::System( 1043): (432) > Value is 1.
07-28 04:52:07.900+0530 I/Tizen::System( 1131): (637) > result is 1.
07-28 04:52:07.900+0530 I/AclService( 1131): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001c (28)
07-28 04:52:07.900+0530 I/Tizen::Net::Wifi( 1087): (637) > OnGetWifiConnectionState with clientId : 1131, AppPkgId : ACL111OMWW
07-28 04:52:07.950+0530 D/WifiStateTracker( 1409): Tizen getWifiState state = 3
07-28 04:52:07.950+0530 I/AclService( 1131): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-28 04:52:07.950+0530 I/Tizen::System( 1043): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-28 04:52:07.970+0530 I/Tizen::System( 1043): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-28 04:52:07.970+0530 I/Tizen::System( 1043): (426) > Result Code is E_SUCCESS.
07-28 04:52:07.970+0530 I/Tizen::System( 1043): (432) > Value is 1.
07-28 04:52:07.970+0530 I/Tizen::System( 1131): (637) > result is 1.
07-28 04:52:07.980+0530 I/PowerManagerService-JNI( 1409): sending ACL screen state 'L'
07-28 04:52:07.980+0530 I/Tizen::System( 1131): (461) > change cpu power policy: keepAwake(true)
07-28 04:52:07.980+0530 I/AclService( 1131): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001c (28)
07-28 04:52:07.980+0530 I/Tizen::Net::Wifi( 1087): (637) > OnGetWifiConnectionState with clientId : 1131, AppPkgId : ACL111OMWW
07-28 04:52:08.050+0530 I/EMAIL_MBOX( 1340): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(39), preview_len(75)
07-28 04:52:08.060+0530 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 1
07-28 04:52:08.070+0530 D/WifiStateTracker( 1409): Tizen getWifiState state = 3
07-28 04:52:08.090+0530 W/AUL_AMD (  452): amd_launch.c: __nofork_processing(1083) > __nofork_processing, cmd: 1, pid: 25720
07-28 04:52:08.090+0530 W/AUL_AMD (  452): amd_launch.c: _resume_app(728) > resume done
07-28 04:52:08.100+0530 I/AclService( 1131): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-28 04:52:08.100+0530 I/Tizen::System( 1043): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-28 04:52:08.120+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10000, data1: 1, data2: 42, data3: 13, data4: 42
07-28 04:52:08.120+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(710) > NOTI_MAIL_ADD
07-28 04:52:08.120+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(717) > mailbox_ugd->mode(1), mailbox_ugd->mailbox_type(1), mailbox_ugd->mailbox_id(13), view_type(0)
07-28 04:52:08.120+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb0b00c58)
07-28 04:52:08.120+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(39) mail_id(39) info(0xb89dfa20)
07-28 04:52:08.120+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
07-28 04:52:08.120+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
07-28 04:52:08.120+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 37
07-28 04:52:08.120+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb0b00c58)
07-28 04:52:08.120+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_cb(884) > Ecore_Thread(0xb0b02760)
07-28 04:52:08.130+0530 I/Tizen::System( 1043): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-28 04:52:08.130+0530 I/Tizen::System( 1043): (426) > Result Code is E_SUCCESS.
07-28 04:52:08.130+0530 I/Tizen::System( 1043): (432) > Value is 1.
07-28 04:52:08.130+0530 I/Tizen::System( 1131): (637) > result is 1.
07-28 04:52:08.130+0530 I/PowerManagerService-JNI( 1409): sending ACL screen state 'F'
07-28 04:52:08.130+0530 I/Tizen::System( 1131): (461) > change cpu power policy: keepAwake(false)
07-28 04:52:08.150+0530 W/AUL_AMD (  452): amd_launch.c: __reply_handler(851) > listen fd(34) , send fd(33), pid(25720), cmd(3)
07-28 04:52:08.190+0530 W/PROCESSMGR(  419): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=25720
07-28 04:52:08.250+0530 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-28 04:52:08.250+0530 I/MALI    (  609): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb9013508] swap changed from sync to async
07-28 04:52:08.250+0530 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-28 04:52:08.270+0530 I/indicator(  498): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.camerasample, pid = 25720"
07-28 04:52:08.270+0530 I/Tizen::System( 1131): (101) > Active App is org.tizen.camerasample. GetApp id ACL111OMWW.AclService
07-28 04:52:08.270+0530 I/CAPI_APPFW_APPLICATION(  609): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-28 04:52:08.270+0530 E/cluster-home(  609): homescreen-main.cpp: app_pause(355) >  app pause
07-28 04:52:08.290+0530 I/CAPI_APPFW_APPLICATION(25720): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-28 04:52:08.300+0530 I/Tizen::System( 1043): (259) > Active app [org.tizen.], current [com.samsun] 
07-28 04:52:08.300+0530 I/Tizen::Io( 1043): (729) > Entry not found
07-28 04:52:08.310+0530 I/Tizen::System( 1043): (157) > change brightness system value.
07-28 04:52:08.320+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:08.320+0530 E/LOCATION( 1131): location-privacy.c: location_get_privacy(174) > CPPAPP use location
07-28 04:52:08.320+0530 I/Tizen::System( 1043): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-28 04:52:08.330+0530 I/Tizen::System( 1043): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-28 04:52:08.330+0530 I/Tizen::System( 1043): (426) > Result Code is E_SUCCESS.
07-28 04:52:08.330+0530 I/Tizen::System( 1043): (432) > Value is 1.
07-28 04:52:08.330+0530 I/Tizen::System( 1131): (637) > result is 1.
07-28 04:52:08.330+0530 I/Tizen::System( 1043): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-28 04:52:08.330+0530 I/Tizen::System( 1043): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-28 04:52:08.330+0530 I/Tizen::System( 1043): (426) > Result Code is E_SUCCESS.
07-28 04:52:08.330+0530 I/Tizen::System( 1043): (432) > Value is 1.
07-28 04:52:08.330+0530 I/Tizen::System( 1131): (637) > result is 1.
07-28 04:52:08.390+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10000, data1: 1, data2: 43, data3: 13, data4: 43
07-28 04:52:08.390+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(710) > NOTI_MAIL_ADD
07-28 04:52:08.390+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(717) > mailbox_ugd->mode(1), mailbox_ugd->mailbox_type(1), mailbox_ugd->mailbox_id(13), view_type(0)
07-28 04:52:08.390+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_cb(884) > Ecore_Thread(0xb0b00c58)
07-28 04:52:08.400+0530 I/EMAIL_MBOX( 1340): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(43), preview_len(75)
07-28 04:52:08.400+0530 I/EMAIL_MBOX( 1340): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(40), preview_len(75)
07-28 04:52:08.450+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb0b00c58)
07-28 04:52:08.450+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(43) mail_id(43) info(0xb8786060)
07-28 04:52:08.450+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
07-28 04:52:08.450+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
07-28 04:52:08.450+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 38
07-28 04:52:08.450+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb0b00c58)
07-28 04:52:08.460+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb87d71e0)
07-28 04:52:08.460+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(40) mail_id(40) info(0xb871e000)
07-28 04:52:08.460+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
07-28 04:52:08.460+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
07-28 04:52:08.460+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 39
07-28 04:52:08.460+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb87d71e0)
07-28 04:52:08.820+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:09.090+0530 E/VCONF   (  958): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
07-28 04:52:09.090+0530 E/VCONF   (  958): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
07-28 04:52:09.090+0530 E/VCONF   (  958): vconf.c: vconf_get_int(2379) > vconf_get_int(958) : file/private/wifi/always_allow_scanning error
07-28 04:52:09.090+0530 E/VCONF   (  958): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
07-28 04:52:09.090+0530 E/VCONF   (  958): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
07-28 04:52:09.090+0530 E/VCONF   (  958): vconf.c: vconf_get_int(2379) > vconf_get_int(958) : file/private/wifi/always_allow_scanning error
07-28 04:52:09.130+0530 I/CAPI_TELEPHONY(  958): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
07-28 04:52:09.150+0530 I/CAPI_TELEPHONY(  958): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
07-28 04:52:09.210+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10000, data1: 1, data2: 44, data3: 13, data4: 44
07-28 04:52:09.210+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(710) > NOTI_MAIL_ADD
07-28 04:52:09.210+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(717) > mailbox_ugd->mode(1), mailbox_ugd->mailbox_type(1), mailbox_ugd->mailbox_id(13), view_type(0)
07-28 04:52:09.210+0530 I/EMAIL_MBOX( 1340): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(42), preview_len(75)
07-28 04:52:09.210+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_cb(884) > Ecore_Thread(0xb87d71e0)
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 4, data3: , data4: 14
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10020, data1: 1, data2: 36, data3: thread_item_count44, data4: 2
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(1106) > NOTI_MAIL_FIELD_UPDATE
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _parse_set_flag_buf(1802) > inbuf = thread_item_count44
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _parse_set_flag_buf(1819) > outer_tok[1] : 44
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(1116) > update_type : 36, value : 2, size of mail_list : 1
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(1354) > idx: [44]
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10000, data1: 1, data2: 45, data3: 13, data4: 44
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(710) > NOTI_MAIL_ADD
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(717) > mailbox_ugd->mode(1), mailbox_ugd->mailbox_type(1), mailbox_ugd->mailbox_id(13), view_type(0)
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb0b02760)
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(42) mail_id(42) info(0xb8885660)
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
07-28 04:52:09.280+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 40
07-28 04:52:09.290+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_cb(884) > Ecore_Thread(0xb0b00c58)
07-28 04:52:09.300+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb0b02760)
07-28 04:52:09.320+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:09.370+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10000, data1: 1, data2: 46, data3: 13, data4: 46
07-28 04:52:09.370+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(710) > NOTI_MAIL_ADD
07-28 04:52:09.370+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(717) > mailbox_ugd->mode(1), mailbox_ugd->mailbox_type(1), mailbox_ugd->mailbox_id(13), view_type(0)
07-28 04:52:09.370+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_cb(884) > Ecore_Thread(0xb0b02760)
07-28 04:52:09.390+0530 E/LOCATION( 1131): location-privacy.c: location_get_privacy(174) > CPPAPP use location
07-28 04:52:09.680+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10000, data1: 1, data2: 47, data3: 13, data4: 47
07-28 04:52:09.680+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(710) > NOTI_MAIL_ADD
07-28 04:52:09.680+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(717) > mailbox_ugd->mode(1), mailbox_ugd->mailbox_type(1), mailbox_ugd->mailbox_id(13), view_type(0)
07-28 04:52:09.680+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_cb(884) > Ecore_Thread(0xb0b03e28)
07-28 04:52:09.750+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10000, data1: 1, data2: 48, data3: 13, data4: 48
07-28 04:52:09.750+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(710) > NOTI_MAIL_ADD
07-28 04:52:09.750+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(717) > mailbox_ugd->mode(1), mailbox_ugd->mailbox_type(1), mailbox_ugd->mailbox_id(13), view_type(0)
07-28 04:52:09.750+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_cb(884) > Ecore_Thread(0xb87009e8)
07-28 04:52:09.820+0530 I/EMAIL_MBOX( 1340): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(44), preview_len(75)
07-28 04:52:09.830+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10000, data1: 1, data2: 49, data3: 13, data4: 49
07-28 04:52:09.830+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(710) > NOTI_MAIL_ADD
07-28 04:52:09.830+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(717) > mailbox_ugd->mode(1), mailbox_ugd->mailbox_type(1), mailbox_ugd->mailbox_id(13), view_type(0)
07-28 04:52:09.830+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb87d71e0)
07-28 04:52:09.830+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(44) mail_id(44) info(0xb8758a48)
07-28 04:52:09.830+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
07-28 04:52:09.830+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
07-28 04:52:09.830+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 41
07-28 04:52:09.830+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb87d71e0)
07-28 04:52:09.840+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:09.840+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_cb(884) > Ecore_Thread(0xb87db4c0)
07-28 04:52:09.890+0530 I/EMAIL_MBOX( 1340): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(47), preview_len(75)
07-28 04:52:09.900+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb0b03e28)
07-28 04:52:09.900+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(47) mail_id(47) info(0xb8725298)
07-28 04:52:09.900+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
07-28 04:52:09.900+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
07-28 04:52:09.900+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 42
07-28 04:52:09.900+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb0b03e28)
07-28 04:52:09.910+0530 I/EMAIL_MBOX( 1340): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(45), preview_len(75)
07-28 04:52:09.960+0530 I/EMAIL_MBOX( 1340): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(48), preview_len(75)
07-28 04:52:09.970+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb0b00c58)
07-28 04:52:09.970+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(44) mail_id(45) info(0xb8950bc8)
07-28 04:52:09.970+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
07-28 04:52:09.970+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
07-28 04:52:09.970+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 43
07-28 04:52:09.970+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb0b00c58)
07-28 04:52:09.970+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb87009e8)
07-28 04:52:09.970+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(48) mail_id(48) info(0xb87185d0)
07-28 04:52:09.970+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
07-28 04:52:09.970+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
07-28 04:52:09.970+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 44
07-28 04:52:09.970+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb87009e8)
07-28 04:52:09.990+0530 I/EMAIL_MBOX( 1340): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(46), preview_len(75)
07-28 04:52:10.040+0530 I/EMAIL_MBOX( 1340): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(41), preview_len(75)
07-28 04:52:10.040+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb0b02760)
07-28 04:52:10.040+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(46) mail_id(46) info(0xb89dfcb0)
07-28 04:52:10.040+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
07-28 04:52:10.040+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
07-28 04:52:10.040+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 45
07-28 04:52:10.040+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb0b02760)
07-28 04:52:10.040+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb895f358)
07-28 04:52:10.040+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(41) mail_id(41) info(0xb89df780)
07-28 04:52:10.040+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
07-28 04:52:10.040+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
07-28 04:52:10.040+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 46
07-28 04:52:10.040+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb895f358)
07-28 04:52:10.050+0530 I/EMAIL_MBOX( 1340): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(49), preview_len(75)
07-28 04:52:10.110+0530 I/Tizen::Net::Wifi( 1087): (928) > The background scan result updated.
07-28 04:52:10.110+0530 I/Tizen::Net::Wifi( 1087): (934) > Fire event [WIFI_EVENT_SCAN_COMPLETED]
07-28 04:52:10.110+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb87db4c0)
07-28 04:52:10.110+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(49) mail_id(49) info(0xb8718950)
07-28 04:52:10.110+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
07-28 04:52:10.110+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
07-28 04:52:10.110+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 47
07-28 04:52:10.130+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb87db4c0)
07-28 04:52:10.240+0530 I/CAPI_TELEPHONY(  958): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
07-28 04:52:10.250+0530 I/CAPI_TELEPHONY(  958): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
07-28 04:52:10.330+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:10.420+0530 E/LOCATION( 1131): location-privacy.c: location_get_privacy(174) > CPPAPP use location
07-28 04:52:10.460+0530 E/CAPI_LOCATION_MANAGER(  958): location_product.c: _location_manager_gps_state_cb(102) > _location_manager_gps_state_cb
07-28 04:52:10.470+0530 I/indicator(  498): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-28 04:52:10.470+0530 I/indicator(  498): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-28 04:52:10.470+0530 I/indicator(  498): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-28 04:52:10.470+0530 I/indicator(  498): indicator_box_util.c: _update_display(585) > "Noti Icon : 146 332 5 28 25"
07-28 04:52:10.470+0530 I/indicator(  498): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 360 5 28 25"
07-28 04:52:10.470+0530 I/indicator(  498): indicator_box_util.c: _update_display(585) > "Noti Icon : active_sync 388 5 27 25"
07-28 04:52:10.470+0530 I/indicator(  498): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-28 04:52:10.470+0530 I/indicator(  498): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-28 04:52:10.470+0530 I/indicator(  498): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-28 04:52:10.470+0530 I/indicator(  498): indicator_box_util.c: _update_display(585) > "Noti Icon : 146 652 5 28 25"
07-28 04:52:10.470+0530 I/indicator(  498): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 680 5 28 25"
07-28 04:52:10.470+0530 I/indicator(  498): indicator_box_util.c: _update_display(585) > "Noti Icon : active_sync 708 5 27 25"
07-28 04:52:10.470+0530 I/Tizen::System( 1043): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-28 04:52:10.470+0530 I/Tizen::System( 1043): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-28 04:52:10.470+0530 I/Tizen::System( 1043): (426) > Result Code is E_SUCCESS.
07-28 04:52:10.470+0530 I/Tizen::System( 1043): (432) > Value is 1.
07-28 04:52:10.480+0530 I/Tizen::System( 1131): (637) > result is 1.
07-28 04:52:10.480+0530 I/Tizen::System( 1043): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-28 04:52:10.480+0530 I/Tizen::System( 1043): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-28 04:52:10.480+0530 I/Tizen::System( 1043): (426) > Result Code is E_SUCCESS.
07-28 04:52:10.480+0530 I/Tizen::System( 1043): (432) > Value is 1.
07-28 04:52:10.480+0530 I/Tizen::System( 1131): (637) > result is 1.
07-28 04:52:10.510+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10000, data1: 1, data2: 50, data3: 13, data4: 50
07-28 04:52:10.510+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(710) > NOTI_MAIL_ADD
07-28 04:52:10.510+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(717) > mailbox_ugd->mode(1), mailbox_ugd->mailbox_type(1), mailbox_ugd->mailbox_id(13), view_type(0)
07-28 04:52:10.510+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_cb(884) > Ecore_Thread(0xb87db4c0)
07-28 04:52:10.580+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 3, data3: , data4: 14
07-28 04:52:10.580+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
07-28 04:52:10.590+0530 I/MALI    (25720): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb8f67050] swap changed from async to sync
07-28 04:52:10.720+0530 I/EMAIL_MBOX( 1340): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(50), preview_len(75)
07-28 04:52:10.770+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb87db4c0)
07-28 04:52:10.770+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(50) mail_id(50) info(0xb8874270)
07-28 04:52:10.770+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
07-28 04:52:10.770+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(1)
07-28 04:52:10.770+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 48
07-28 04:52:10.770+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb87db4c0)
07-28 04:52:10.830+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:11.030+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10000, data1: 1, data2: 51, data3: 13, data4: 51
07-28 04:52:11.030+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(710) > NOTI_MAIL_ADD
07-28 04:52:11.030+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(717) > mailbox_ugd->mode(1), mailbox_ugd->mailbox_type(1), mailbox_ugd->mailbox_id(13), view_type(0)
07-28 04:52:11.030+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_cb(884) > Ecore_Thread(0xb87db4c0)
07-28 04:52:11.040+0530 I/EMAIL_MBOX( 1340): email-mailbox-list.c: mailbox_list_make_mail_item_data(5649) > account_id(1), mail_id(51), preview_len(75)
07-28 04:52:11.070+0530 I/indicator(  498): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-28 04:52:11.070+0530 I/indicator(  498): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-28 04:52:11.070+0530 I/indicator(  498): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-28 04:52:11.070+0530 I/indicator(  498): indicator_box_util.c: _update_display(585) > "Noti Icon : 146 363 5 28 25"
07-28 04:52:11.070+0530 I/indicator(  498): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 391 5 28 25"
07-28 04:52:11.070+0530 I/indicator(  498): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-28 04:52:11.070+0530 I/indicator(  498): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-28 04:52:11.070+0530 I/indicator(  498): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-28 04:52:11.070+0530 I/indicator(  498): indicator_box_util.c: _update_display(585) > "Noti Icon : 146 683 5 28 25"
07-28 04:52:11.070+0530 I/indicator(  498): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 711 5 28 25"
07-28 04:52:11.090+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(1520) > User.Email.NetworkStatus
07-28 04:52:11.090+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(1556) > NOTI_DOWNLOAD_FINISH
07-28 04:52:11.110+0530 I/EMAIL_COMM( 1340): email-utils.c: _generate_best_pattern(1607) > bestPatternLength: 6
07-28 04:52:11.110+0530 I/EMAIL_COMM( 1340): email-utils.c: _generate_best_pattern(1627) > formattedLength: 7
07-28 04:52:11.110+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _check_req_handle_list(1935) > handle(2), g_req_handle_list((nil))
07-28 04:52:11.110+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _check_req_handle_list(1941) > handle_count(0)
07-28 04:52:11.110+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _check_req_handle_list(1951) > handle_count(0)
07-28 04:52:11.110+0530 I/EMAIL_MBOX( 1340): email-mailbox-list-other-items.c: mailbox_load_more_messages_item_add(831) > get_more_messages item already exist.
07-28 04:52:11.110+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(939) > Ecore_Thread(0xb87db4c0)
07-28 04:52:11.110+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(948) > thread_id(51) mail_id(51) info(0xb8873950)
07-28 04:52:11.110+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_add_seed_mail_cb(953) > (req, mailbox_ugd) mode(1, 1), mailbox_type(1, 1), mailbox_id(13, 13)
07-28 04:52:11.110+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(740) > total_count(1), unread_count(0)
07-28 04:52:11.110+0530 I/EMAIL_MBOX( 1340): email-mailbox-title.c: mailbox_navi_title_increase_mail_count(752) > total mail count is 49
07-28 04:52:11.110+0530 I/EMAIL_MBOX( 1340): email-mailbox-worker.c: mailbox_add_mail_worker_finish_cb(1125) > Ecore_Thread(0xb87db4c0)
07-28 04:52:11.190+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 20010, data1: 1, data2: 3, data3: , data4: 0
07-28 04:52:11.190+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(324) > NOTI_ACCOUNT_UPDATE_SYNC_STATUS
07-28 04:52:11.220+0530 I/AUL     (24792): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/email-service, ret : 0
07-28 04:52:11.230+0530 I/AUL     (24792): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/email-service, ret : 0
07-28 04:52:11.260+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 20010, data1: 1, data2: 2, data3: , data4: 0
07-28 04:52:11.260+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(324) > NOTI_ACCOUNT_UPDATE_SYNC_STATUS
07-28 04:52:11.330+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:11.510+0530 E/LOCATION( 1131): location-privacy.c: location_get_privacy(174) > CPPAPP use location
07-28 04:52:11.830+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:12.340+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:12.550+0530 E/LOCATION( 1131): location-privacy.c: location_get_privacy(174) > CPPAPP use location
07-28 04:52:12.560+0530 I/Tizen::System( 1043): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-28 04:52:12.560+0530 I/Tizen::System( 1043): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-28 04:52:12.560+0530 I/Tizen::System( 1043): (426) > Result Code is E_SUCCESS.
07-28 04:52:12.560+0530 I/Tizen::System( 1043): (432) > Value is 1.
07-28 04:52:12.560+0530 I/Tizen::System( 1131): (637) > result is 1.
07-28 04:52:12.560+0530 I/Tizen::System( 1043): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-28 04:52:12.560+0530 I/Tizen::System( 1043): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-28 04:52:12.560+0530 I/Tizen::System( 1043): (426) > Result Code is E_SUCCESS.
07-28 04:52:12.560+0530 I/Tizen::System( 1043): (432) > Value is 1.
07-28 04:52:12.560+0530 I/Tizen::System( 1131): (637) > result is 1.
07-28 04:52:12.840+0530 D/dalvikvm( 1695): GC_EXPLICIT freed 31K, 52% free 2864K/5959K, external 1962K/2073K, paused 43ms
07-28 04:52:12.850+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:13.350+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:13.600+0530 E/LOCATION( 1131): location-privacy.c: location_get_privacy(174) > CPPAPP use location
07-28 04:52:13.850+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:14.350+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:14.640+0530 E/LOCATION( 1131): location-privacy.c: location_get_privacy(174) > CPPAPP use location
07-28 04:52:14.640+0530 I/Tizen::System( 1043): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-28 04:52:14.640+0530 I/Tizen::System( 1043): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-28 04:52:14.640+0530 I/Tizen::System( 1043): (426) > Result Code is E_SUCCESS.
07-28 04:52:14.640+0530 I/Tizen::System( 1043): (432) > Value is 1.
07-28 04:52:14.640+0530 I/Tizen::System( 1131): (637) > result is 1.
07-28 04:52:14.640+0530 I/Tizen::System( 1043): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-28 04:52:14.650+0530 I/Tizen::System( 1043): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-28 04:52:14.650+0530 I/Tizen::System( 1043): (426) > Result Code is E_SUCCESS.
07-28 04:52:14.650+0530 I/Tizen::System( 1043): (432) > Value is 1.
07-28 04:52:14.650+0530 I/Tizen::System( 1131): (637) > result is 1.
07-28 04:52:14.860+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:14.900+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 22, data3: , data4: 14
07-28 04:52:14.900+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
07-28 04:52:15.310+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 21, data3: , data4: 14
07-28 04:52:15.310+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
07-28 04:52:15.350+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:15.380+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 20, data3: , data4: 14
07-28 04:52:15.380+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
07-28 04:52:15.490+0530 D/camerasample(25720): timer terminated ...
07-28 04:52:15.580+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 19, data3: , data4: 14
07-28 04:52:15.580+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
07-28 04:52:15.580+0530 W/TIZEN_N_CAMERA(25720): camera.c: __mm_camera_message_callback(672) > _CAMERA_EVENT_TYPE_SHUTTER_SOUND callback (nil)
07-28 04:52:15.610+0530 D/camerasample(25720): got JPEG data - data [0xb91b5c58], length [116228], width [640], height [480]
07-28 04:52:15.610+0530 D/camerasample(25720): /opt/usr/media/Images/IMAGE_2015-07-28_04:52:15.jpg
07-28 04:52:15.630+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 18, data3: , data4: 14
07-28 04:52:15.630+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
07-28 04:52:15.630+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 17, data3: , data4: 14
07-28 04:52:15.630+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
07-28 04:52:15.690+0530 I/camerasample(25720): Failed to create email message
07-28 04:52:15.770+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 16, data3: , data4: 14
07-28 04:52:15.770+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
07-28 04:52:15.770+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 15, data3: , data4: 14
07-28 04:52:15.770+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
07-28 04:52:15.850+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 14, data3: , data4: 14
07-28 04:52:15.850+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
07-28 04:52:15.850+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(99) > STORE_ENABLE: subtype: 10004, data1: 1, data2: 13, data3: , data4: 14
07-28 04:52:15.850+0530 I/EMAIL_MBOX( 1340): email-mailbox-noti-mgr.c: _gdbus_event_mailbox_receive(879) > NOTI_MAIL_UPDATE
07-28 04:52:15.850+0530 E/LOCATION( 1131): location-privacy.c: location_get_privacy(174) > CPPAPP use location
07-28 04:52:15.920+0530 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-28 04:52:15.920+0530 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-28 04:52:15.930+0530 E/SurfaceFlinger( 1409): redraw failed: empty invalid region
07-28 04:52:15.990+0530 I/AUL_PAD (  496): sigchild.h: __launchpad_sig_child(142) > dead_pid = 25720 pgid = 25720
07-28 04:52:15.990+0530 I/AUL_PAD (  496): sigchild.h: __sigchild_action(123) > dead_pid(25720)
07-28 04:52:15.990+0530 I/AUL_PAD (  496): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-28 04:52:15.990+0530 I/AUL_PAD (  496): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-28 04:52:16.010+0530 I/Tizen::System( 1043): (246) > Terminated app [org.tizen.camerasample]
07-28 04:52:16.010+0530 I/Tizen::Io( 1043): (729) > Entry not found
07-28 04:52:16.010+0530 W/CRASH_MANAGER(27660): worker.c: worker_job(1236) > 112572063616d143803933
